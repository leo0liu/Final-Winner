
using UnityEngine;

public enum MegaAttractType
{
	Attract,
	Repulse,
	Rotate,
}

[AddComponentMenu("Modifiers/Attractor Shape")]
public class MegaAttractorShape : MegaModifier
{
	public MegaShape		shape;
	public int				curve;
	public MegaAttractType	attractType = MegaAttractType.Attract;
	public float			distance = 0.0f;
	public float			rotate = 0.0f;
	public float			force = 0.0f;
	public float			slide = 0.0f;
	public AnimationCurve	crv = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));
	public int				itercount = 4;
	//MegaSpline				spline;
	int						k;
	Vector3					tangent;
	float					alpha;
	Vector3					delta;
	Vector3					nvp;
	Vector3					dir = Vector3.zero;
	Matrix4x4				rottm = Matrix4x4.identity;
	float					slidealpha;
	Matrix4x4				swtm;
	Matrix4x4				swltm;
	Matrix4x4				lwtm;
	Matrix4x4				wltm;
	public float			limit = 1.0f;
	float limit2 = 0.0f;
	Vector3	shapepos;

	public override string ModName() { return "Attractor Shape"; }
	public override string GetHelpURL() { return "?page_id=338"; }

	public Vector3 FindNearestPointWorld(Vector3 p, int iterations, ref float alpha)
	{
		return swtm.MultiplyPoint3x4(FindNearestPoint(swltm.MultiplyPoint3x4(p), iterations, ref alpha));
	}

	float positiveInfinity;
	float num2;
	//int iterations;

	Vector3[]	points;

	void PrepareShape()
	{
		if ( points == null )
			points = new Vector3[101];

		int kt = 0;

		int ix = 0;
		for ( float i = 0.0f; i <= 1.0f; i += 0.01f )
			points[ix++] = shape.splines[curve].Interpolate(i, true, ref kt);
	}

	void Find(Vector3 p)
	{
		positiveInfinity = float.PositiveInfinity;
		num2 = 0.0f;
		//iterations = Mathf.Clamp(itercount, 0, 5);

		for ( int i = 0; i < 101; i++ )
		{
			float a = (float)i / 100.0f;
			Vector3 vector = points[i] - p;	//shape.splines[curve].Interpolate(i, true, ref kt);	// - p;	//this.GetPositionOnSpline(i) - p;
			float sqrMagnitude = vector.sqrMagnitude;
			if ( positiveInfinity > sqrMagnitude )
			{
				positiveInfinity = sqrMagnitude;
				num2 = a;
			}
		}
	}

	// Find nearest point
	public Vector3 FindNearestPoint(Vector3 p, int iterations, ref float alpha)
	{
		int kt = 0;

		Find(p);
		MegaSpline spl = shape.splines[curve];
		for ( int j = 0; j < itercount; j++ )
		{
			float num6 = 0.01f * Mathf.Pow(10.0f, -((float)j));
			float num7 = num6 * 0.1f;
			for ( float k = Mathf.Clamp01(num2 - num6); k <= Mathf.Clamp01(num2 + num6); k += num7 )
			{
				Vector3 vector2 = spl.Interpolate(k, true, ref kt) - p;	
				float num9 = vector2.sqrMagnitude;

				if ( positiveInfinity > num9 )
				{
					positiveInfinity = num9;
					num2 = k;
				}
			}
		}

		alpha = num2;
		return shape.InterpCurve3D(curve, num2, true);
	}

	public override Vector3 Map(int i, Vector3 p)
	{
		p = tm.MultiplyPoint3x4(p);

		{
			Vector3 vwp = lwtm.MultiplyPoint3x4(p);	//transform.TransformPoint(p);
			Vector3 qc = vwp - shapepos;

			if ( qc.sqrMagnitude < limit2 )
			{
				Vector3 splpos = FindNearestPointWorld(vwp, itercount, ref alpha);
				
				switch ( attractType )
				{
					case MegaAttractType.Attract:	delta = splpos - vwp;		break;
					case MegaAttractType.Repulse:	delta = vwp - splpos;		break;
					case MegaAttractType.Rotate:	delta = splpos - vwp;		break;
				}

				float len  = delta.magnitude;
				
				if ( len  < distance )
				{
					float val = distance - len;
					float calpha = val / distance;
					float cval = crv.Evaluate(calpha);
							
					if ( attractType == MegaAttractType.Attract || attractType == MegaAttractType.Repulse )
					{
						Vector3 move = delta.normalized * val * cval * force;
				
						if ( attractType == MegaAttractType.Attract )
						{					
							if ( move.magnitude <= len )	// can used squared here?
							{
								//nvp = transform.worldToLocalMatrix.MultiplyPoint3x4(vwp + move);
								nvp = wltm.MultiplyPoint3x4(vwp + move);
							}
							else
							{
								//nvp = transform.worldToLocalMatrix.MultiplyPoint3x4(splpos);
								nvp = wltm.MultiplyPoint3x4(splpos);
							}
						}
						else
						{
							nvp = wltm.MultiplyPoint3x4(vwp + move);
							//nvp = p + move;
						}
					}
					else
					{
						float alpha1;

						if ( slide >= 0.0f )
							alpha1 = alpha + ((1.0f - alpha) * slidealpha) * cval;
						else
							alpha1 = alpha + (alpha * slidealpha) * cval;
				
						if ( alpha1 < 0.0f )
							alpha1 = 0.0f;
						else
							if ( alpha1 >= 1.0f )
								alpha1 = 0.99999f;
							
						Vector3 fwd = swtm.MultiplyPoint3x4(shape.splines[curve].InterpCurve3D(alpha1, true, ref k));
						
						float alpha2 = alpha1 + 0.01f;
				
						if ( alpha1 + 0.01f >= 1.0f )
							alpha2 = alpha1 - 0.01f;

						Vector3 fwd1 = swtm.MultiplyPoint3x4(shape.splines[curve].InterpCurve3D(alpha2, true, ref k));
						
						if ( alpha + 0.01f < 1.0f )
							dir = (fwd - fwd1).normalized;
						else
							dir = (fwd1 - fwd).normalized;
						
						Vector3 rightVector = Vector3.Cross(delta, dir).normalized;

						rottm.SetColumn(0, rightVector);
						rottm.SetColumn(1, Vector3.Cross(-rightVector, dir));
						rottm.SetColumn(2, dir);
						rottm.SetColumn(3, fwd);
	
						float y = len * Mathf.Cos((-90.0f + rotate * val * cval) * Mathf.Deg2Rad);
						float x = len * Mathf.Sin((-90.0f + rotate * val * cval) * Mathf.Deg2Rad);

						nvp = rottm.MultiplyPoint3x4(new Vector3(y, x, p.z));
						//nvp = transform.localToWorldMatrix.inverse.MultiplyPoint3x4(nvp);
						nvp = wltm.MultiplyPoint3x4(nvp);
					}
				}
				else
					nvp = p;
	
				p = nvp;
			}
		}

		return invtm.MultiplyPoint3x4(p);
	}

	public override bool ModLateUpdate(MegaModContext mc)
	{
		return Prepare(mc);
	}

	public override bool Prepare(MegaModContext mc)
	{
		if ( shape )
		{
			PrepareShape();
			limit2 = limit * limit;
			shapepos = shape.transform.position;
			slidealpha = slide * 0.01f;
			swtm = shape.transform.localToWorldMatrix;
			swltm = shape.transform.worldToLocalMatrix;
			lwtm = transform.localToWorldMatrix;
			wltm = transform.worldToLocalMatrix;
			return true;
		}

		return false;
	}
}
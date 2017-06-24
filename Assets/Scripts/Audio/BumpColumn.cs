using UnityEngine;
using System.Collections;

public class BumpColumn : MonoBehaviour {

    AudioSource bumpColumn;

    void Awake()
    {
        bumpColumn = GetComponent<AudioSource>();

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.other.name=="Ball")
        {
            bumpColumn.Play();
        }
    }
}

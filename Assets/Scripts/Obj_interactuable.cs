using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj_interactuable : MonoBehaviour
{

    [SerializeField]
    AudioSource audioSource;

    [SerializeField]
    AudioClip clip;


    public void OnClick()
    {
        audioSource.PlayOneShot(clip);
    }
    
}

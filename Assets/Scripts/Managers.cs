using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    [SerializeField] 
    GameObject manager;

    private void Awake()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
    }
}

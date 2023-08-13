using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No_destruir : MonoBehaviour
{
    [SerializeField]
    string tagToPreserve;

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag(tagToPreserve);

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No_destruir : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}

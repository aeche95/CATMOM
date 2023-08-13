using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obj_fondo : MonoBehaviour
{
    [SerializeField]
    Sprite[] images;

    [SerializeField]
    bool isAbandoned = false;

    [SerializeField]
    Image image;

    public void Abandon(bool newIsAbandoned)
    {
        isAbandoned = newIsAbandoned;

        image.sprite = images[isAbandoned? images.Length-1 : 0];
    }

    private void Awake()
    {
        image = GetComponent<Image>();
    }

}

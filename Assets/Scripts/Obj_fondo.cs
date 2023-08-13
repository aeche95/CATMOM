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
    bool isDamaged = false;

    [SerializeField]
    Image image;

    public void Damage()
    {
        isDamaged = true;
        image.sprite = images[1];
    }

    private void Awake()
    {
        image = GetComponent<Image>();
    }

}

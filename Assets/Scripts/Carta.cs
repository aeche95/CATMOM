using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carta : MonoBehaviour
{

    [SerializeField]
    public int value;

    [SerializeField]
    public Sprite face;

    [SerializeField]
    public bool isFacingFront = false;

    [SerializeField]
    Vector2 gridPosition;

    [SerializeField]
    public Image image;

    [SerializeField]
    Sprite frontSprite;

    [SerializeField]
    public Sprite backSprite;

    [SerializeField]
    public bool isActive = true;

    [SerializeField]
    Button button;

    public int Flip()
    {
        isFacingFront = !isFacingFront;

        SetSprite();

        if(isFacingFront)
        {
            return value;
        }
        else
        {
            return 0;
        }
    }

    public void Initialize(Sprite faceSprite, int Value, Vector2 position)
    {
        image.sprite = faceSprite;
        value = Value;
        gridPosition = position;

        PlaceCard();
    }

    void PlaceCard()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector3(125 * (2 * gridPosition.x + 1), -250 * (2 * gridPosition.y + 1));
    }

    void SetSprite()
    {
        image.sprite = isFacingFront ? frontSprite : backSprite;
    }

    public void DeactivateCard()
    {
        isActive = false;
        image.enabled = false;
    }

    public int GetValue()
    {
        return value;
    }

    public Button GetButton()
    {
        return button;
    }
}

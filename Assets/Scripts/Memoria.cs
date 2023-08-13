using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memoria : MonoBehaviour
{

    [SerializeField]
    int rows = 4;

    [SerializeField]
    int columns = 2;

    [SerializeField]
    GameObject cardPrefab;

    [SerializeField]
    int[] values = new int[4*2];

    [SerializeField]
    Carta firstCard;

    [SerializeField]
    Carta secondCard;

    [SerializeField]
    GameObject[] cards = new GameObject[4*2];

    [SerializeField]
    Sprite[] sprites = new Sprite[4];

    public void OnCardTriggered(Carta cardTriggered)
    {

       int cardValue = cardTriggered.Flip();
       if(firstCard.GetValue() == -1)
       {
           firstCard = cardTriggered;
           return;
       }
       else if(secondCard.GetValue() == -1)
       {
            secondCard = cardTriggered;
            EvaluateCards();
       }
        else
        {
            ResetCards();
        }

    }

    private void EvaluateCards()
    {
        if(firstCard.GetValue() == secondCard.GetValue())
        {
            firstCard.DeactivateCard();
            secondCard.DeactivateCard();

        }
        ResetCards();
    }

    private void ResetCards()
    {
        firstCard = secondCard = null;
    }

    public void StartGame()
    {
        for(int i = 0; i < cards.Length; i++)
        {
            cards[i] = Instantiate(cardPrefab);
            Carta carta = cards[i].GetComponent<Carta>();

            int newValue = values[i];
            
            Vector2 newPosition = new Vector2(i%4,i/4);

            Sprite newSprite = sprites[newValue];

            carta.Initialize(newSprite,newValue,newPosition);

            carta.GetButton().onClick.AddListener(() => OnCardTriggered(carta));

        }
    }


}

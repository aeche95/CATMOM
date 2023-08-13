using System;
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

    }

    private void EvaluateCards()
    {
        
    }

    public void StartGame()
    {
        
    }


}

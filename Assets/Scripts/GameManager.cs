using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    int days = 0;

    [SerializeField]
    int health = 100;

    int GetDias()
    {
        return days;
    }

    public void PassDay()
    {
        days += 1;
    }

    public int GetHealth()
    {
        return health;
    }

    public void AddHealth(int healthToAdd)
    {
        health += healthToAdd;
    }

}

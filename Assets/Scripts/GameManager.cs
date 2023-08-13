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

    [SerializeField]
    int currentSceneIndex = 0;

    [SerializeField]
    Button previousSceneButton;

    [SerializeField]
    Button nextSceneButton;

    [SerializeField]
    Dictionary<int, string> sceneNameDictionay;

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

    public void ChangeScene(int sceneDirection)
    {
        currentSceneIndex += sceneDirection;
        currentSceneIndex %= sceneNameDictionay.Count;
        SceneManager.LoadScene(sceneNameDictionay[currentSceneIndex]);
    }

    private void Awake()
    {
        sceneNameDictionay.Add(0, "Sala");
        sceneNameDictionay.Add(1, "Habitacion");
        sceneNameDictionay.Add(2, "Cocina");
    }
}

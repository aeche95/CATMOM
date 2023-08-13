using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameManagerSO data;

    [SerializeField]
    string nonInteractablesTag;

    [SerializeField]
    bool PlayerWon = false;

    int GetDias()
    {
        return data.days;
    }

    public void PassDay()
    {
        data.days += 1;
    }

    public int GetHealth()
    {
        return data.health;
    }

    public void AddHealth(int healthToAdd)
    {
        data.health += healthToAdd;
    }

    public void SetAbandoned(bool newAbandoned)
    {
        data.isAbandoned = newAbandoned;
        
        SetAbandonedItems(data.isAbandoned);
        
    }

    void CheckAbandoned()
    {
        SetAbandonedItems(data.isAbandoned);
    }

    void SetAbandonedItems(bool areAbandoned)
    {
        GameObject[] nonInteractables = GameObject.FindGameObjectsWithTag(nonInteractablesTag);
        foreach (GameObject gameObject in nonInteractables)
        {
            Obj_fondo obj_Fondo = gameObject.GetComponent<Obj_fondo>();
            obj_Fondo.Abandon(areAbandoned);
        }
    }

    private void Awake()
    {
        SceneManager.sceneLoaded += CheckIfSceneIsAbandoned;
    }

    private void CheckIfSceneIsAbandoned(Scene arg0, LoadSceneMode arg1)
    {
        CheckAbandoned();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChangeManager : MonoBehaviour
{
    [SerializeField]
    int currentSceneIndex = 0;

    [SerializeField]
    Button previousSceneButton;

    [SerializeField]
    Button nextSceneButton;

    Dictionary<int, string> sceneNameDictionary;

    public void ChangeScene(int sceneDirection)
    {
        currentSceneIndex += sceneDirection;
        currentSceneIndex %= sceneNameDictionary.Count;
        SceneManager.LoadScene(sceneNameDictionary[currentSceneIndex]);
    }

    private void Awake()
    {
        sceneNameDictionary = new Dictionary<int, string>();
        sceneNameDictionary.Add(0, "Sala");
        sceneNameDictionary.Add(1, "Habitacion");
        sceneNameDictionary.Add(2, "Cocina");
    }
}

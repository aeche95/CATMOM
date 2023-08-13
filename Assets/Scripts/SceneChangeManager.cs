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
    Canvas canvas; 

    public void ChangeScene(int sceneDirection)
    {
        currentSceneIndex += sceneDirection;
        if(currentSceneIndex >= SceneManager.sceneCount)
        {
            currentSceneIndex = 1;
        }
        if(currentSceneIndex < 1)
        {
            currentSceneIndex = SceneManager.sceneCount - 1;
        }
       
        SceneManager.LoadScene(currentSceneIndex,LoadSceneMode.Additive);
    }

    private void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        if (currentSceneIndex == 0)
        {
            canvas.enabled = false;
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
    {
        currentSceneIndex = scene.buildIndex;
        if(currentSceneIndex == 0)
        {
            canvas.enabled = false;
        }
        else
        {
            canvas.enabled = true;
        }
    }
}

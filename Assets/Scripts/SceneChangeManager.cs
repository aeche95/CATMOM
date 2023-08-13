using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChangeManager : MonoBehaviour
{
    [SerializeField]
    int currentSceneIndex = 0;

    [SerializeField]
    int sceneCount = 4;

    [SerializeField]
    Button previousSceneButton;

    [SerializeField]
    Button nextSceneButton;

    public void ChangeScene(int sceneDirection)
    {
        currentSceneIndex += sceneDirection;

        if(currentSceneIndex >= sceneCount)
        {
            currentSceneIndex = 0;
        }

        if(currentSceneIndex < 0)
        {
            currentSceneIndex = sceneCount - 1;
        }

        SceneManager.LoadScene(currentSceneIndex);
    }
    private void Awake()
    {
        SetButtonVisibility(SceneManager.GetActiveScene(), LoadSceneMode.Single);
        SceneManager.sceneLoaded += SetButtonVisibility;
    }

    private void SetButtonVisibility(Scene scene,LoadSceneMode loadSceneMode)
    {
        previousSceneButton.GetComponent<Image>().enabled = nextSceneButton.GetComponent<Image>().enabled = !SceneManager.GetActiveScene().name.Equals("Main");
    }
}

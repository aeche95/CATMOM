using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChangeManager : MonoBehaviour
{
    [SerializeField]
    public SceneManagementSO data;

    public void ChangeScene(int sceneDirection)
    {
        data.lastSceneIndex = data.currentSceneIndex;
        data.currentSceneIndex += sceneDirection;
        if (data.currentSceneIndex >= SceneManager.sceneCountInBuildSettings) 
        {
            data.currentSceneIndex = 2;
        }
        if (data.currentSceneIndex < 2) 
        {
            data.currentSceneIndex = SceneManager.sceneCountInBuildSettings - 1;
        }
       
        SceneManager.LoadScene(data.currentSceneIndex);
        
    }
}

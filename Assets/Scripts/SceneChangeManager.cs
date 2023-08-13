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
        if (data.currentSceneIndex >= data.playableScenes.Length) 
        {
            data.currentSceneIndex = 0;
        }
        if (data.currentSceneIndex < 0) 
        {
            data.currentSceneIndex = data.playableScenes.Length - 1;
        }
       
        SceneManager.LoadScene(data.currentSceneIndex);
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Code : MonoBehaviour
{
    UIDocument Main;

    private void OnEnable() {
      Main = GetComponent<UIDocument>(); 
      VisualElement root = Main.rootVisualElement;
    }

    public void LoadScene(string sceneName )
    {
        SceneManager.LoadScene(sceneName);
    }
}

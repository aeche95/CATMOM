using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
        
    public void backtogame()
    {
        SceneManager.LoadScene("Main");
    }
}

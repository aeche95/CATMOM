using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    
    public void playGame()
    {
        SceneManager.LoadScene("Sala");
    }
}

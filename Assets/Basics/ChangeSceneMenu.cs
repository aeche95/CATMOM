using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeSceneMenu : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene("Sala");
    }

    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }
}

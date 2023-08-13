using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    UIManagerSO data;

    [SerializeField]
    Button pausa;

    [SerializeField]
    Canvas menuPausa;

    private void Awake()
    {
        Cursor.SetCursor(data.normalCursor, data.cursorOffset, data.cursorMode);
    }

    public void TogglePause()
    {
        data.isPaused = !data.isPaused;
        menuPausa.enabled = data.isPaused;
    }

    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Cursor.SetCursor(data.clickingCursor, data.cursorOffset, data.cursorMode);
        }
        else
        {
            Cursor.SetCursor(data.normalCursor, data.cursorOffset, data.cursorMode);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        TogglePause();
        SceneManager.LoadScene(0);

    }
}

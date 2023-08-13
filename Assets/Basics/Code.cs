using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Code : MonoBehaviour
{
    UIDocument Main;

    Button play_button;
    Button credits_button;
    Button quit_button;


    private void OnEnable() {
      Main = GetComponent<UIDocument>(); 
      VisualElement root = Main.rootVisualElement;

      play_button = root.Q<Button>("play");
      credits_button = root.Q<Button>("credits");
      quit_button = root.Q<Button>("quit");

      // Callback
      play_button.RegisterCallback<ClickEvent>(playGame);
      //credits_button.RegisterCallback<ClickEvent>(credits);
      //quit_button.RegisterCallback<ClickEvent>(quit);

    }

    public string Sala;
    
    void playGame(ClickEvent evt)
    {
        SceneManager.LoadScene("Managers", LoadSceneMode.Additive);
        SceneManager.LoadScene("Sala", LoadSceneMode.Single);
    }
}

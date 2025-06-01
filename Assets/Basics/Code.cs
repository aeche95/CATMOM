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
      play_button.RegisterCallback<ClickEvent>(OnPlayButtonPressed);
      credits_button.RegisterCallback<ClickEvent>(OnCreditsButtonPressed);
      quit_button.RegisterCallback<ClickEvent>(OnQuitButtonPressed);

    }

    public string PrimeraHabitacion;
    
    public void OnPlayButtonPressed(ClickEvent evt)
    {
        SceneManager.LoadScene(PrimeraHabitacion);
    }

    public void OnCreditsButtonPressed(ClickEvent evt)
    {
        SceneManager.LoadScene("Credits");
    }

    public void OnQuitButtonPressed(ClickEvent evt)
    {
        Application.Quit();
    }
}

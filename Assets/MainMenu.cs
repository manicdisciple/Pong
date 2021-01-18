using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button newGameButton;
    public Button exitButton; 
    public string newGameSceneName;

    public void Awake() {
        newGameButton.onClick.AddListener(NewGame);
        exitButton.onClick.AddListener(ExitGame);
    }
    public void NewGame() {
        SceneManager.LoadScene(newGameSceneName);
    }

    public void ExitGame() {
        Application.Quit();
    }
}

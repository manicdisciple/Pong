using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button btnStartNewGame;
    public Button btnExitGame; 
    public string newGameSceneName;

    
    public void NewGame() {
        SceneManager.LoadScene(newGameSceneName);
    }

    public void ExitGame() {
        Application.Quit();
    }
}

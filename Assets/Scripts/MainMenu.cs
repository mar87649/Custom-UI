using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;

    public void LoadGame()
    {
        Debug.Log("Game is Starting..");
        SceneManager.LoadScene("GameScene", LoadSceneMode.Additive);
        HideMainMenu();
        HideOptions();
        Debug.Log("Game is loaded");
    }
    public void ShowOptions()
    {
        optionsMenu.SetActive(true);
    }
    public void HideOptions()
    {
        optionsMenu.SetActive(false);
    }
    public void HideMainMenu()
    {
        mainMenu.SetActive(true);
    }
    public void ShowMainMenu()
    {
        mainMenu.SetActive(false);
    }
    public void CloseApp()
    {
        Debug.Log("App is Clossing...");
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TestScript : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    public float fontSize;
    public Color color;
    public float volume;
    public bool darkMode;
    public GameObject panel;
    private Color32 redLight = new Color32(255, 1, 1, 255);
    private Color32 redDark = new Color32(255, 50, 50, 255);
    private Color32 blueLight = new Color32(1, 1, 255, 255);
    private Color32 blueDark = new Color32(50, 50, 255, 255);
    private Color32 greenLight = new Color32(50, 255, 1, 255);
    private Color32 greenDark = new Color32(50, 255, 50, 255);
    private Color32 mainDark = new Color32(255, 255, 255, 255);
    private Color32 mainLight = new Color32(1, 1, 1, 255);
    private Color32 panelColorLight = new Color32(255, 255, 255, 100);
    private Color32 panelColorDark = new Color32(150, 150, 150, 100);
    private GameObject mainMenu;
    private GameObject optionsMenu;

    void Start()
    {

    }
    private void Update()
    {
        tmp.text = "Font Size is: " + fontSize;
    }
    #region UI methods
    public void SetFontSize(float _fontSize)
    {
        fontSize = _fontSize;
        tmp.fontSize = fontSize;
    }
    public void SetFontColor(Color _color)
    {
        color = _color;
        tmp.color = color;
    }
    public void SetUIMode(bool _darkMode)
    {
        if (_darkMode)
        {
            panel.GetComponent<Image>().color = panelColorDark;
            SetFontColor(mainDark);
        }else
        { 
            panel.GetComponent<Image>().color = panelColorLight;
            SetFontColor(mainLight);            
        }
    }
    public void SetAudioVolume(float _volume)
    {
        volume = _volume;
    }
    public void CloseApp()
    {
        Debug.Log("App is Clossing...");
    }
    public void StartApp()
    {
        Debug.Log("App is starting..");
    }
#endregion
#region Button Methods
    public void ChangeFontBlue()
    {
        SetFontColor(blueLight);        
    }
    public void ChangeFontRed()
    {
        SetFontColor(redLight); 
    }
    public void ChangeFontGreen()
    {
        SetFontColor(greenLight); 
    }
    public void ChangeFontBlack()
    {
        SetFontColor(mainLight); 
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
#endregion
#region Scene Manager
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Additive);
    }
#endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OptionsMenu : MonoBehaviour
{
    public float fontSize;
    public Color color;
    public float volume;
    public GameObject panel;
    private Color32 redLight = new Color32(255, 1, 1, 255);
    private Color32 redDark = new Color32(255, 50, 50, 255);
    private Color32 greenLight = new Color32(50, 255, 1, 255);
    private Color32 blueLight = new Color32(1, 1, 255, 255);
    public TextMeshProUGUI loremIpsum;
    private Color32 mainLight = new Color32(1, 1, 1, 255);
    private Color32 panelColorLight = new Color32(255, 255, 255, 100);

    public void SetFontSize(float _fontSize)
    {
        fontSize = _fontSize;
        loremIpsum.fontSize = Mathf.RoundToInt(_fontSize*100);
        Debug.Log(Mathf.RoundToInt(_fontSize*100));
    }
    public void SetFontColor(Color _color)
    {
        color = _color;
        loremIpsum.color = _color;
            }
    public void SetAudioVolume(float _volume)
    {
        volume = _volume;
    }
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
}

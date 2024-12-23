using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSettingsUI : MonoBehaviour
{
    public AudioSettings audioSettings;
    public Text idText;
    public Slider volumeSlider; 
    public GameObject listPanel; 
    public GameObject textPanel; 
    public AudioContentType audioContentType; 
    public AudioClipData[] dangerousClips; 
    public AudioClipData[] friendlyClips; 
    public AudioClipData[] neutralClips;
    private void Start()
    {
        
        idText.text = "ID: " + audioSettings.uniqueID;

        
        volumeSlider.value = audioSettings.audioClips[0].volume; 
        volumeSlider.onValueChanged.AddListener(OnVolumeChange);
    }

    public void ShowList()
    {
        listPanel.SetActive(true);
        textPanel.SetActive(false);

        switch (audioSettings.audioContentType)
        {
            case AudioContentType.Dangerous:
                
                break;
            case AudioContentType.Friendly:
                
                break;
            case AudioContentType.Neutral:
                
                break;
        }
    }

    public void ShowText()
    {
        listPanel.SetActive(false);
        textPanel.SetActive(true);
        
    }

    public void HideAll()
    {
        listPanel.SetActive(false);
        textPanel.SetActive(false);
    }

    private void OnVolumeChange(float value)
    {
        
        foreach (var clipData in audioSettings.audioClips)
        {
            clipData.volume = value;
        }
    }
     
}

    

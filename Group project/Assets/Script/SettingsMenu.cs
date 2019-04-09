using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SettingsMenu : MonoBehaviour, IPointerEnterHandler
{
    public AudioMixer audioMixer;

    public AudioSource highlightedAudio;

    Resolution[] resolutions;

    public Dropdown resDropdown;

    void Start()
    {
        resolutions = Screen.resolutions;

        resDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;


        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resDropdown.AddOptions(options);
        resDropdown.value = currentResolutionIndex;
        resDropdown.RefreshShownValue();
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetResolution(int resIndex)
    {
        Resolution resolution = resolutions[resIndex];

        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void MuteVolume(bool isMute)
    {
        SetVolume(-80);

        if(isMute == false)
        {
            float volume = 0;
            SetVolume(volume);
        }
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void RestartGame(string gameReset)
    {
        SceneManager.LoadScene(gameReset);
    }

    public void OnPointerEnter(PointerEventData ped)
    {
        highlightedAudio.Play();
    }
}

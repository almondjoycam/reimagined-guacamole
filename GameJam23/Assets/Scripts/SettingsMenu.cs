using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    [Header("Volume Configuration")]
    [SerializeField]
    Slider volumeSlider;
    float currentVolume = 0.5f;

    [Header("Graphics Configuration")]
    [SerializeField]
    TMP_Dropdown graphicsDropdown;
    List<string> graphicsOptions = new List<string>();

    [Header("Resolution Configuration")]
    [SerializeField]
    TMP_Dropdown resDropdown;
    Resolution[] resolutions;
    List<string> resOptions = new List<string>();
    bool isFullScreen;

    GameControls controls;
    EventSystem eventSystem;

    // set up controls messages in Awake
    void Awake()
    {
        controls = new GameControls();
        controls.UI.Cancel.performed += ctx => Back();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Set up the computer's available graphics levels in menu
        graphicsDropdown.ClearOptions();
        for (int i = 0; i < QualitySettings.names.Length; i++)
        {
            graphicsOptions.Add(QualitySettings.names[i]);
        }
        graphicsDropdown.AddOptions(graphicsOptions);

        // Set up the computer's available resolutions in the menu
        resolutions = Screen.resolutions;
        resDropdown.ClearOptions();
        for (int i = 0; i < resolutions.Length; i++)
        {
            resOptions.Add(resolutions[i].ToString());
        }
        resDropdown.AddOptions(resOptions);

        isFullScreen = Screen.fullScreen;

        // Get the event system
        eventSystem = GameObject.Find("EventSystem").GetComponent<EventSystem>();
        eventSystem.SetSelectedGameObject(volumeSlider.gameObject);
    }

    // When the menu is enabled
    void OnEnable()
    {
        // currentVolume gets set to whatever music player is
        volumeSlider.SetValueWithoutNotify(currentVolume);

        int graphicsIndex = QualitySettings.GetQualityLevel();
        if (graphicsDropdown)
        {
            graphicsDropdown.SetValueWithoutNotify(graphicsIndex);
        }

        if (resolutions != null)
        {
            int resIndex = Array.IndexOf(resolutions,
                Screen.currentResolution.ToString());
            if (resDropdown)
            {
                resDropdown.SetValueWithoutNotify(resIndex);
            }
        }
    }

    // Changing Volume
    public void VolumeChange()
    {
        currentVolume = volumeSlider.value;
    }

    // Changing Graphics
    public void GraphicsChange()
    {
        QualitySettings.SetQualityLevel(graphicsDropdown.value);
    }

    // Changing Resolution
    public void ResChange()
    {
        Screen.SetResolution(resolutions[resDropdown.value].width,
                             resolutions[resDropdown.value].height,
                             isFullScreen);
    }

    // Back Button
    public void Back()
    {
        gameObject.SetActive(false);
    }
}

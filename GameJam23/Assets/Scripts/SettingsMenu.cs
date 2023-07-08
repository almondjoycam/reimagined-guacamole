using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    [Header("Volume Configuration")]
    [SerializeField]
    Slider volumeSlider;

    [Header("Graphics Configuration")]
    [SerializeField]
    TMP_Dropdown graphicsDropdown;

    [Header("Resolution Configuration")]
    [SerializeField]
    TMP_Dropdown resDropdown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

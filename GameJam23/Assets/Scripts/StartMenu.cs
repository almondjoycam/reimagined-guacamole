using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField]
    GameObject credits;
    [SerializeField]
    GameObject settings;
    [SerializeField]
    GameObject startButton;

    EventSystem eventSystem;

    // Start is called before the first frame update
    void Start()
    {
        credits.SetActive(false);
        settings.SetActive(false);

        eventSystem = GameObject.Find("EventSystem").GetComponent<EventSystem>();
        eventSystem.SetSelectedGameObject(startButton);
    }

    // Start button
    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }

    // Cwedits button
    public void ShowCredits()
    {
        credits.SetActive(true);
    }

    // settings button
    public void ShowSettings()
    {
        settings.SetActive(true);
    }

    // quit button
    public void QuitGame()
    {
        Application.Quit();
    }
}

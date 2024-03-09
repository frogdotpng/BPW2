using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private int nextScene;

    [Header("Credits field")]
    [SerializeField] public GameObject creditsGohere;

    [Header("Settings field")]
    [SerializeField] public GameObject settingsGohere;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;

    }

    public void Play() 
    {
        SceneManager.LoadScene(nextScene);
    }

    public void Quit() 
    { 
        Application.Quit();
        Debug.Log("The player has Quit the Game");
    }

    public void Settings()
    {
        settingsGohere.SetActive(true);
    }

    public void Credits()
    {
        creditsGohere.SetActive(true);
    }

    public void CloseCredits() {
        creditsGohere.SetActive(false);
    }

    public void CloseSettings()
    {
        settingsGohere.SetActive(false);
    }

}

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

    [Header("Game parts")]
    [SerializeField] public GameObject MenuCollection;
    [SerializeField] public GameObject GameCollection;
    [SerializeField] public GameObject btutons;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;

    }

    public void Play() 
    {
        MenuCollection.SetActive(false);
        GameCollection.SetActive(true);
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
        btutons.SetActive(false);
    }

    public void CloseCredits() {
        creditsGohere.SetActive(false);
        btutons.SetActive(true);
    }

    public void CloseSettings()
    {
        settingsGohere.SetActive(false);
    }

}

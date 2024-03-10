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
    [SerializeField] public GameObject controlsGohere;

    [Header("Game parts")]
    [SerializeField] public GameObject MenuCollection;
    [SerializeField] public GameObject GameCollection;
    [SerializeField] public GameObject btutons;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Play() 
    {
        MenuCollection.SetActive(false);
        GameCollection.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Quit() 
    { 
        Application.Quit();
        Debug.Log("The player has Quit the Game");
    }

    public void Controls()
    {
        controlsGohere.SetActive(true);
        btutons.SetActive(false);
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

    public void CloseControls()
    {
        controlsGohere.SetActive(false);
        btutons.SetActive(true);
    }

}

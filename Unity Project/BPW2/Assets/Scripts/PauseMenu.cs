using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [Header("Gameobjects")]
    [SerializeField] Slider musicSlider;
    [SerializeField] GameObject player;
    [SerializeField] GameObject eventManager;

    [Header("Menu things")]
    [SerializeField] GameObject PausedMenu;
    [SerializeField] GameObject MainMenu;
    [SerializeField] GameObject TheGame;

    private bool menuActivated = false;

    // Update is called once per frame
    void Update()
    {
        ChangeVolume();

        if (Input.GetKeyDown(KeyCode.Q) && menuActivated)
        {
            MenuUit();
            Cursor.lockState = CursorLockMode.Locked;
        }

        else if (Input.GetKeyDown(KeyCode.Q) && !menuActivated)
        {
            MenuAan();
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void ChangeVolume()
    {
        AudioListener.volume = musicSlider.value;
    }

    public void GoBackToMenu()
    {
        TheGame.SetActive(false);
        MainMenu.SetActive(true);
        PausedMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        MenuUit();
    }

    private void MenuUit()
    {
        player.SetActive(true);
        eventManager.SetActive(true);

        Debug.Log("Menu uit");
        Time.timeScale = 1;
        PausedMenu.SetActive(false);
        menuActivated = false;
    }
    private void MenuAan()
    {
        player.SetActive(false);
        eventManager.SetActive(false);

        Debug.Log("Menu aan");
        Time.timeScale = 0;
        PausedMenu.SetActive(true);
        menuActivated = true;
    }

    public void MenuUitVoorKnop() {
        MenuUit();
        Cursor.lockState = CursorLockMode.Locked;
    }
}

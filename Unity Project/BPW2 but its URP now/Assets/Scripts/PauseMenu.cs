using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] Slider musicSlider;
    [SerializeField] GameObject PausedMenu;
    [SerializeField] GameObject player;
    [SerializeField] GameObject eventManager;

    private bool menuActivated = false;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeVolume();
        if (Input.GetKeyDown(KeyCode.Q) && menuActivated)
        {
            player.SetActive(true);
            eventManager.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;

            Debug.Log("Menu uit");
            Time.timeScale = 1;
            PausedMenu.SetActive(false);
            menuActivated = false;
        }

        else if (Input.GetKeyDown(KeyCode.Q) && !menuActivated)
        {
            player.SetActive(false);
            eventManager.SetActive(false);

            Cursor.lockState = CursorLockMode.None;

            Debug.Log("Menu aan");
            Time.timeScale = 0;
            PausedMenu.SetActive(true);
            menuActivated = true;
        }
    }

    void ChangeVolume()
    {
        AudioListener.volume = musicSlider.value;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EventManager : MonoBehaviour
{
    [Header("PostProcessing")]
    [SerializeField] public GameObject DayPostProcessing;
    [SerializeField] public GameObject NightPostProcessing;
    [SerializeField] public GameObject RedPostProcessing;


    [Header("Stuff")]
    [SerializeField] public GameObject Nighttimestuff;
    [SerializeField] public GameObject Daytimestuff;
    [SerializeField] public GameObject RedStuff;


    [Header("Skybox")]
    [SerializeField] public Material DaySkyBox;
    [SerializeField] public Material NightSkyBox;
    [SerializeField] public Material RedSkyBox;


    [Header("Rust")]
    [SerializeField] public GameObject TracksToMakeRusty;
    [SerializeField] public Material RustDay;
    [SerializeField] public Material RustNight;

    [Header("Woods")]
    [SerializeField] public GameObject PlanksToWood;
    [SerializeField] public Material WoodDay;
    [SerializeField] public Material WoodNight;

    [Header("Misc")]
    [SerializeField] public AudioSource SoundEffect;
    [SerializeField] public AudioSource BGM;

    private bool isDay = false;
    private bool isRed = true;

    // Update is called once per frame

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        BGM.Play();
    }


    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            SoundEffect.Play();

            Debug.Log("Isday is currently " + isDay + "isRed is currently" + isRed);

            if (isDay == true && isRed == false)          // het wordt nacht
            {
                SwitchToNight();
            }

            else if (isDay == false && isRed == false)    //het wordt dag
            {
                SwitchToDay();
            }

            else if (isDay == false && isRed == true)    //het wordt dag
            {
                SwitchToRed();
            }
        }
    }

    private void SwitchToNight()
    {
        Debug.Log("het wordt nu nacht");        //debug
        RenderSettings.skybox = NightSkyBox;    //verandert skybox
        RenderSettings.fog = true;              //zet fog aan

        DayPostProcessing.SetActive(false);      //switcht van night naar day post processing
        NightPostProcessing.SetActive(true);
        RedPostProcessing.SetActive(false);

        Nighttimestuff.SetActive(true);        //switcht van nighttimestuff naar daytimestuff
        Daytimestuff.SetActive(false);
        RedStuff.SetActive(false);

        //materials veranderen
        TracksToMakeRusty.GetComponent<Renderer>().material = RustNight;
        PlanksToWood.GetComponent<Renderer>().material = WoodNight;

        //music stuff
        BGM.pitch = 0.8f;

        isDay = false;
        isRed = false;

    }

    private void SwitchToDay()
    {
        Debug.Log("het wordt nu dag");          //debug
        RenderSettings.skybox = DaySkyBox;      //verandert skybox
        RenderSettings.fog = false;             //zet fog aan

        DayPostProcessing.SetActive(true);      //switcht van night naar day post processing
        NightPostProcessing.SetActive(false);
        RedPostProcessing.SetActive(false);

        Nighttimestuff.SetActive(false);        //switcht van nighttimestuff naar daytimestuff
        Daytimestuff.SetActive(true);
        RedStuff.SetActive(false);


        //materials veranderen
        TracksToMakeRusty.GetComponent<Renderer>().material = RustDay;
        PlanksToWood.GetComponent<Renderer>().material = WoodDay;

        //music
        BGM.pitch = 1f;

        isDay = false;
        isRed = true;
    }

    private void SwitchToRed()
    {
        Debug.Log("het wordt nu rood");          //debug
        RenderSettings.skybox = RedSkyBox;      //verandert skybox
        RenderSettings.fog = false;             //zet fog aan

        DayPostProcessing.SetActive(false);      //switcht van night naar day post processing
        NightPostProcessing.SetActive(false);
        RedPostProcessing.SetActive(true);

        Nighttimestuff.SetActive(false);        //switcht van nighttimestuff naar daytimestuff
        Daytimestuff.SetActive(false);
        RedStuff.SetActive(true);

        //materials veranderen
        TracksToMakeRusty.GetComponent<Renderer>().material = RustDay;
        PlanksToWood.GetComponent<Renderer>().material = WoodNight;

        //music
        BGM.pitch = 0.24f;

        isDay = true;
        isRed = false;
    }
}

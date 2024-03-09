using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EventManager : MonoBehaviour
{
    [Header("PostProcessing")]
    [SerializeField] public GameObject DayPostProcessing;
    [SerializeField] public GameObject NightPostProcessing;

    [Header("Stuff")]
    [SerializeField] public GameObject Nighttimestuff;
    [SerializeField] public GameObject Daytimestuff;

    [Header("Skybox")]
    [SerializeField] public Material DaySkyBox;
    [SerializeField] public Material NightSkyBox;

    [Header("Rust")]
    [SerializeField] public GameObject TracksToMakeRusty;
    [SerializeField] public Material RustDay;
    [SerializeField] public Material RustNight;

    [Header("Woods")]
    [SerializeField] public GameObject PlanksToWood;
    [SerializeField] public Material WoodDay;
    [SerializeField] public Material WoodNight;

    private bool isDay = true;

    // Update is called once per frame

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isDay == true)          // het wordt nacht
            {
                SwitchToNight();
            }

            else if (isDay == false)    //het wordt dag
            {
                SwitchToDay();
            }
        }
    }

    private void SwitchToNight()
    {
        Debug.Log("het wordt nu nacht");        //debug
        RenderSettings.skybox = NightSkyBox;    //verandert skybox
        RenderSettings.fog = true;              //zet fog aan

        DayPostProcessing.SetActive(false);     //switcht van day naar night post processing
        NightPostProcessing.SetActive(true);
        Nighttimestuff.SetActive(true);         //switcht van daytimestuff naar nighttimestuff
        Daytimestuff.SetActive(false);

        //materials veranderen
        TracksToMakeRusty.GetComponent<Renderer>().material = RustNight;
        PlanksToWood.GetComponent<Renderer>().material = WoodNight;

        isDay = false;
    }

    private void SwitchToDay()
    {
        Debug.Log("het wordt nu dag");          //debug
        RenderSettings.skybox = DaySkyBox;      //verandert skybox
        RenderSettings.fog = false;             //zet fog aan

        DayPostProcessing.SetActive(true);      //switcht van night naar day post processing
        NightPostProcessing.SetActive(false);
        Nighttimestuff.SetActive(false);        //switcht van nighttimestuff naar daytimestuff
        Daytimestuff.SetActive(true);

        //materials veranderen
        TracksToMakeRusty.GetComponent<Renderer>().material = RustDay;
        PlanksToWood.GetComponent<Renderer>().material = WoodDay;

        isDay = true;
    }
}

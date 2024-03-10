using System.Collections;
using System.Collections.Generic;
//using UnityEditor.ShaderGraph;
using UnityEngine;

public class Credits : MonoBehaviour
{
    [SerializeField] private GameObject normalCredits;
    [SerializeField] private GameObject easterEggCredits;
    [SerializeField] private GameObject thisButton;

    public void CreditsEasterEgg()
    {
        normalCredits.SetActive(false);
        easterEggCredits.SetActive(true);
        thisButton.SetActive(false);      
    }
}

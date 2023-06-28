using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;

[RequireComponent(typeof(SteamVR_LaserPointer))]
public class LaserHandler : MonoBehaviour
{
    private SteamVR_LaserPointer laserPointer;

    public GameObject PlanetsMenu;
    public GameObject JupiterLecture;

    private void OnEnable()
    {
        laserPointer = GetComponent<SteamVR_LaserPointer>();
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }


    private void PointerClick(object sender, PointerEventArgs e)
    {
        Button button = e.target.GetComponent<Button>();
        if (button != null)
        {
            if(button.gameObject.name == "ScegliPianeta" && JupiterLecture != null && PlanetsMenu != null)
            {
                JupiterLecture.SetActive(false);
                PlanetsMenu.SetActive(true);
            } else button.onClick.Invoke();
        } else if (e.target.GetComponent<SphereCollider>() != null)
        {
            PlanetsMenu.SetActive(false);
            string name = e.target.name;
            if (name == "Jupiter")
            {
                JupiterLecture.SetActive(true);
            }
        }
    }

    public void PointerInside(object sender, PointerEventArgs e)
    {
        Button button = e.target.GetComponent<Button>();
        if (button != null) { 
            laserPointer.color = Color.yellow;
        }
        else if (e.target.GetComponent<SphereCollider>() != null)
        {
            laserPointer.color = Color.yellow;
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        Button button = e.target.GetComponent<Button>();
        if (button != null) { 
            laserPointer.color = Color.red;
        }
        else if (e.target.GetComponent<SphereCollider>() != null)
        {
            laserPointer.color = Color.red;
        }
    }
}
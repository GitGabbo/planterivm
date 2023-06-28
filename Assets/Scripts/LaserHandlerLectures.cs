using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;

[RequireComponent(typeof(SteamVR_LaserPointer))]
public class LaserHandlerLectures : MonoBehaviour
{
    private SteamVR_LaserPointer laserPointer;

    public GameObject PlanetsMenu;
    public GameObject JupiterLecture;
    public GameObject SaturnLecture;
    public GameObject NeptuneLecture;

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
            if (button.gameObject.name == "ScegliPianeta")
            {
                JupiterLecture.SetActive(false);
                SaturnLecture.SetActive(false);
                NeptuneLecture.SetActive(false);
                PlanetsMenu.SetActive(true);
            }
            else
            {
                button.onClick.Invoke();
                if(button.name == "Esci")
                {
                    Destroy(GameObject.Find("Player"));
                }
            }
        } else if (e.target.GetComponent<SphereCollider>() != null)
        {
            PlanetsMenu.SetActive(false);
            string name = e.target.name;
            if (name == "Jupiter")
            {
                JupiterLecture.SetActive(true);
            } else if(name == "Saturn")
            {
                SaturnLecture.SetActive(true);
            }
            else if (name == "Neptune")
            {
                NeptuneLecture.SetActive(true);
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
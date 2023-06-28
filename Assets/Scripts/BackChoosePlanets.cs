using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackChoosePlanets : MonoBehaviour
{
    public GameObject planetsMenu;

    public void CloseAndOpenPlanetsMenu()
    {
        this.transform.parent.transform.parent.gameObject.SetActive(false);
        planetsMenu.SetActive(true);
    }
}

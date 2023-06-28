using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.Extras;

[RequireComponent(typeof(SteamVR_LaserPointer))]
public class LaserHandlerMainMenu : MonoBehaviour
{
    private SteamVR_LaserPointer laserPointer;

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
            if(button.name != "Istruzioni button" && button.name != "TornaIndietro") Destroy(GameObject.Find("Player"));
            button.onClick.Invoke();
        }
    }

    public void PointerInside(object sender, PointerEventArgs e)
    {
        Button button = e.target.GetComponent<Button>();
        if (button != null)
        {
            laserPointer.color = Color.yellow;
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        Button button = e.target.GetComponent<Button>();
        if (button != null)
        {
            laserPointer.color = Color.red;
        }
    }
}

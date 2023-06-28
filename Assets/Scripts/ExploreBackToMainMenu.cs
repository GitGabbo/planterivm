using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class ExploreBackToMainMenu : MonoBehaviour
{
    public SteamVR_Action_Boolean backToMainMenu;
    public SteamVR_Input_Sources handType;

    private void Start()
    {
        backToMainMenu.AddOnStateUpListener(RightMenuUp, SteamVR_Input_Sources.RightHand);
        backToMainMenu.AddOnStateUpListener(LeftMenuUp, SteamVR_Input_Sources.LeftHand);
    }

    private void LeftMenuUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Destroy(GameObject.Find("UFO"));
        SceneManager.LoadScene("MainMenu");
    }

    private void RightMenuUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Destroy(GameObject.Find("UFO"));
        SceneManager.LoadScene("MainMenu");
    }
}

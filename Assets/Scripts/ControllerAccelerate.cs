using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Valve.VR;

public class ControllerAccelerate : MonoBehaviour
{

    private GameObject player;
    private bool isAccelerating;
    private bool isBackwarding;
    public GameObject vrCameraRotation;
    float defaultSpeed;
    public float speed;
    // a reference to the action
    public SteamVR_Action_Boolean Accelerate;
    // a reference to the hand
    public SteamVR_Input_Sources handType;

    // Start is called before the first frame update
    void Start()
    {
        Accelerate.AddOnStateDownListener(RightTriggerDown, SteamVR_Input_Sources.RightHand);
        Accelerate.AddOnStateUpListener(RightTriggerUp, SteamVR_Input_Sources.RightHand);
        Accelerate.AddOnStateDownListener(LeftTriggerDown, SteamVR_Input_Sources.LeftHand);
        Accelerate.AddOnStateUpListener(LeftTriggerUp, SteamVR_Input_Sources.LeftHand);
        player = GameObject.FindGameObjectWithTag("Player");
        isAccelerating = false;
        isBackwarding = false;
        defaultSpeed = 0.008f;
        speed = 0.1f;
    }

    public void RightTriggerUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Trigger is up");
        StopUfo();
    }

    public void RightTriggerDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Trigger is down");
        AccelerateUfo();
    }

    public void LeftTriggerUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Trigger is up");
        StopUfo();
    }

    public void LeftTriggerDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Trigger is down");
        BackwardUfo();
    }

    private void Update()
    {
        if (isAccelerating)
        {
            Forward();
        }
        if (isBackwarding)
        {
            Backward();
        }
    }

    private void Forward()
    {
        Vector3 angles = vrCameraRotation.transform.rotation.eulerAngles + new Vector3(0.0f, 180.0f, 0.0f);
        player.transform.Translate(Quaternion.Euler(angles) * Vector3.forward * speed);
    }

    private void Backward()
    {
        Vector3 angles = vrCameraRotation.transform.rotation.eulerAngles + new Vector3(0.0f, 180.0f, 0.0f);
        player.transform.Translate(Quaternion.Euler(angles) * Vector3.forward * -speed);
    }

    public void AccelerateUfo()
    {
        isAccelerating = true;
    }

    public void BackwardUfo()
    {
        isBackwarding = true;
    }

    public void StopUfo()
    {
        isAccelerating = false;
        isBackwarding = false;
    }

    public void SetSpeed(float scale)
    {
        this.speed = defaultSpeed * scale;
        if(this.speed < defaultSpeed)
        {
            this.speed = defaultSpeed;
        } else if(this.speed > 0.1f)
        {
            this.speed = 0.1f;
        }
    }
}

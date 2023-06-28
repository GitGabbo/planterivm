using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        GameObject.Find("VRCamera").GetComponent<Camera>().fieldOfView = 60.0f;
    }


}

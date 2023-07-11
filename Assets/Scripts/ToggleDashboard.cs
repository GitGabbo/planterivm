using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleDashboard : MonoBehaviour
{

    public GameObject dashboardCanvas;
    GameObject player;
    public float radius;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("UFO");
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);

        if (dist < radius)
        {
            dashboardCanvas.SetActive(true);
        } else 
        {
            dashboardCanvas.SetActive(false);   
        }
    }
}

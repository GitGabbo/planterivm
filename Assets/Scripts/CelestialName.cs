using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelestialName : MonoBehaviour
{

    public GameObject player;
    private GameObject[] canvasNames;

    // Start is called before the first frame update
    void Start()
    {
        canvasNames = GameObject.FindGameObjectsWithTag("CelestialNameCanvas");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject canvasName in canvasNames) {
            canvasName.transform.LookAt(player.transform.position);
            canvasName.transform.Rotate(new Vector3(0, 180, 0));
        }
    }
}

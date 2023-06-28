using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    Portal[] portalgroup;
    GameObject[] celestials;
    int count;
    bool forward;

    void Start()
    {
        count = int.Parse(this.name[9].ToString());
        forward = this.name[7] == 'b' ? false : true;
        celestials = GameObject.FindGameObjectsWithTag("Celestial");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided");
        if (other.CompareTag("Player"))
        {
            Debug.Log("Collided with player");
            int newIndex = forward?((count + 1) % 9):((count - 1) % 9);
            if (newIndex<0){
                newIndex=8;
            }
            GameObject portal;
            if(forward){
                portal = GameObject.Find("Portal-b-" + newIndex);
            }
            else{
                portal = GameObject.Find("Portal-f-" + newIndex);
            }
            Debug.Log(portal);
            Debug.Log(newIndex);
            float celestialScale = celestials[newIndex].transform.localScale.x;
            float celestialOffset = celestials[newIndex].transform.position.x;
            other.GetComponent<ControllerAccelerate>().SetSpeed(celestialScale);
            if (forward)
            {
                foreach (GameObject celestial in celestials)
                {
                    celestial.transform.position = new Vector3(celestial.transform.position.x - celestialOffset, celestial.transform.position.y, celestial.transform.position.z);
                }
            } else
            {
                foreach (GameObject celestial in celestials)
                {
                    celestial.transform.position = new Vector3(celestial.transform.position.x - celestialOffset, celestial.transform.position.y, celestial.transform.position.z);
                }
            }
            other.transform.position = new Vector3(celestials[newIndex].transform.position.x, other.transform.position.y, portal.transform.position.z - 1);
            other.transform.LookAt(celestials[newIndex].gameObject.transform);
            other.transform.Rotate(0, 180, 0);
        }
    }
}
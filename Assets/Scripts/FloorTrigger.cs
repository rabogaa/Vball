using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTrigger : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }


    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
        }
    }

    void Fall(Collider other)
    {
        other.GetComponentInParent<Rigidbody>().useGravity = true;
    }
    
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Elevator : MonoBehaviour
{
    public Rigidbody rb;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (rb.mass < 1)
            {
                rb.AddForce(0f, 5, 0f);
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if(rb.mass < 1)
            {
                rb.AddForce(0f, 5, 0f);
            }
        }
    }
}

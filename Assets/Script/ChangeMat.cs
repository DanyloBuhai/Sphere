using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMat : MonoBehaviour
{
    public Material mat;
    public Renderer rend;
    public float mas;
    
    public Rigidbody rb;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            rend.material = mat;
            rb.mass = mas;
        }
    }
}

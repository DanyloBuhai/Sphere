using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    Rigidbody rb;
    public Rigidbody trap;
    public GameManager gm;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "FinishPlatform")
        {
            UnLockLevel();
            SceneManager.LoadScene(6);
        }

        if (collision.collider.tag == "Trap")
        {
           trap.isKinematic = false;
        }
    }

    public void UnLockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levels") && PlayerPrefs.GetInt("levels") < 5)
        {
            PlayerPrefs.SetInt("levels", currentLevel + 1);
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    void FixedUpdate()
    {
        MovementLogic();

        if (rb.transform.position.y < 0f)
        {
            gm.RestartLevel();
        }
    }

    private void MovementLogic()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(h, 0.0f, v);
        rb.AddForce(movement * speed);
    }
}

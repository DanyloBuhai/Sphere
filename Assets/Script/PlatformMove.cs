using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public GameObject[] wp;
    int CurrentTarget;
    float rotSpeed;
    public float Speed;
    float wpRadius=1;
    void Update()
    {
        if (Vector3.Distance(wp[CurrentTarget].transform.position, transform.position) < wpRadius)
        {
            CurrentTarget++;
            if(CurrentTarget >= wp.Length)
            {
                CurrentTarget = 0;
            }  
        }

        transform.position = Vector3.MoveTowards(transform.position, wp[CurrentTarget].transform.position, Speed*Time.deltaTime);
    }
}

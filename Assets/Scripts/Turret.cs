using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject fire;
    public Transform shootpoint;
    public float TurretTimer;
    public bool inRange;
    public float startTime;
    public Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        TurretTimer = 3f;
        startTime = TurretTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (TurretTimer > 0)
        {
            TurretTimer = TurretTimer - Time.deltaTime;
        }
        else
        {

            if (inRange)
            {
                shoot();
            }
        }
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = false;
        }
    }

    void shoot()
    {
        Instantiate(fire, shootpoint.position, shootpoint.rotation);
        TurretTimer = startTime;
        
    }
}

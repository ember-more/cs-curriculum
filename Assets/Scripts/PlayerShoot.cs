using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject fire;
    public Transform shootpoint;
    public float timer;
    public float startTime;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 1f;
        startTime = timer;
    }

    // Update is called once per frame
    
    void Update()
    {
        if (timer > 0)
        {
            timer = timer - Time.deltaTime;
        }
        else
        {
            if (Input.GetButton("Fire1"))
            {
                Vector3 mousePos = Input.mousePosition;
                Shoot();
            } 
        }
        
        
    }

    void Shoot()
    {
        Instantiate(fire, shootpoint.position, shootpoint.rotation);
        timer = startTime;
        
    }
}

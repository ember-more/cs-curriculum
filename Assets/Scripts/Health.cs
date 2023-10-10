using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

public class Health : MonoBehaviour


{
    private float timer;
    public float originalTimer = (float)1.5;
    
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        timer = originalTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            currentHealth -= 1;
        }
    }

    
}

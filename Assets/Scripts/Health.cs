using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

using UnityEngine.SceneManagement;

public class Health : MonoBehaviour


{
    public float timer;
    public bool iframes;
    public Hub hub;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        hub = GameObject.FindObjectOfType<Hub>();
        timer = 1.5f;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (iframes)
        {
            timer -= Time.deltaTime;
        }
        
        if (timer < 0)
        {
            timer = 1f;
            iframes = false;
        }

        if (Time.deltaTime < 0)
        {
            timer = 1f;
            iframes = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            if (!iframes)
            {
                ChangeHealth(-1);
                iframes = true;
            }
            else
            {
                ChangeHealth(0);
            }
        }
    }

    void ChangeHealth(int amount)
    {
        hub.health = hub.health + amount;
        if (hub.health < 1)
        {
            Death();
        }
    }

    void Death()
    {
        hub.health = 10;
        hub.coins = 0;
        SceneManager.LoadScene("Start");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pot"))
        {
            ChangeHealth(1);
            other.gameObject.SetActive(false);
        }
    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hub : MonoBehaviour
{
    public static Hub hub;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;
    public int coins;
    public int health;


    private void Awake()
    {
        if (hub != null && hub != this)
        {
            Destroy(gameObject);
        }
        else
        {
            hub = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        coins = 0;
        health = 10;
    }

    private void Update()
    {
        healthText.text = "Health: " + health.ToString();
        coinText.text = "Coins: " + coins.ToString();
    }
}

    


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hub : MonoBehaviour
{
    public static Hub instance;

    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;

    public int currentCoins = 0;
    public int currentHealth = 10;
    public Coins coins;
    public Health health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        coinText.text = "Coins: " + currentCoins;
        healthText.text = "Health: " + currentHealth;
    }

    public void IncreaseCoins(int value)
    {
        currentCoins += value;
        coinText.text = "Coins: " + currentCoins.ToString();
    }
    
}

    

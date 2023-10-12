
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
    public int value;

    // Start is called before the first frame update
    void Start()
    {
        coinText.text = "Coins: " + currentCoins;
    }

    private void Update()
    {
        healthText.text = "Health: " + currentHealth;
    }

    public void IncreaseCoins(int value)
    {
        currentCoins += 1;
        coinText.text = "Coins: " + currentCoins;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            
        }
    }
}

    


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;

    public TMP_Text coinText;
    public TMP_Text healthText;

    public int currentCoins = 0;
    public int currentHealth = 10;
    public Coins Coins;
    public Health Health;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
        coinText.text = currentCoins.ToString();
        healthText.text = currentHealth.ToString();
    }

    public void IncreaseCoins(int value)
    {
        
    }
}

    

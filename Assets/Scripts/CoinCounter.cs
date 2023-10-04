
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;

    public TMP_Text coinText;

    public int currentCoins = 0;

    // Start is called before the first frame update
    void Start()
    {
        coinText.text = "COINS: " + currentCoins.ToString();
    }

    public void IncreaseCoins(int value)
    {
        currentCoins += 1;
        coinText.text = "COINS: " + currentCoins.ToString();
    }
}

    

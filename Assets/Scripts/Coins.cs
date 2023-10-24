using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public Hub hub;
    // Start is called before the first frame update
    void Start()
    {
        hub = GameObject.FindObjectOfType<Hub>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(message: "Coins: " + hub.coins);
    }

   private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            CollectCoins( 1);
            other.gameObject.SetActive(false);
        }
    }

   void CollectCoins(int amount)
   {
       hub.coins = hub.coins + amount;
       hub.coins++;
   }
}

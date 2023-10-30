using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Transform DropPoint;
    public GameObject Coin;
    public float CoinTimer = 3f;
    public float startTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Death();
        }
    }

    void Death()
    {
        gameObject.SetActive(false);
        CoinTimer -= Time.deltaTime;
        if (CoinTimer < 3f)
        {
            timerEnded();
        }
    }

    void timerEnded()
    {
        Instantiate(Coin, DropPoint.position, DropPoint.rotation);
    }
   
}

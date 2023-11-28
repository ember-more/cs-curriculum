using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float FireSpeed;
    public float DestroyWait = 2f;
    // Start is called before the first frame update
    void Start()
    {
        FireSpeed = 5f;
        Invoke("FireGone", DestroyWait);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(FireSpeed * Time.deltaTime, 0f));
    }

    void FireGone()
    {
        Destroy(gameObject);
    } 
}

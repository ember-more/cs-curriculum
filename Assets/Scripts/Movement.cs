using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool overworld;
    public float xSpeed;
    public float ySpeed;

    private float xDirection;
    private float yDirection;

    private float xVector;
    private float yVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (overworld)
        {
            xDirection = Input.GetAxis("Horizontal");
            xVector = xSpeed * xDirection * Time.deltaTime;
            transform.Translate(xVector, 0, 0);
            yDirection = Input.GetAxis("Vertical");
            yVector = ySpeed * yDirection * Time.deltaTime;
            transform.Translate(0, yVector, 0); 
        }
        else
        {
            xDirection = Input.GetAxis("Horizontal");
            xVector = xSpeed * xDirection * Time.deltaTime;
            transform.Translate(xVector, 0, 0);
        }
    }
    
}

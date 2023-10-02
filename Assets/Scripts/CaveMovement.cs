using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveMovement : MonoBehaviour
{
    public float xSpeed;

    private float xDirection;

    private float xVector;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xSpeed * xDirection * Time.deltaTime;
        // x = x + xVector
        //transform.position = transform.position + new Vector3(xVector, 0, 0);
        //transform.position += new Vector3(xVector, 0, 0);
        transform.Translate(xVector, 0, 0);
    }
}

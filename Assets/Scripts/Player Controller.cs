using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 24.0f;
    public float zRange1 = -18.7f;
    public float zRange2 = -5.4f;
    public float yRange = 2.27f;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //Create and use boundaries so player stays in certain range
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z > zRange2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange2);
        }

        if (transform.position.z < zRange1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange1);
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }
        //Move Player character
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);  
    }
}

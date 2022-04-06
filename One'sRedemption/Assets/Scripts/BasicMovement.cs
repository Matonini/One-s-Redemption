using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    public float movspeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        Vector3 inputVector;
        inputVector.z = Input.GetAxis("Horizontal");
        inputVector.x = Input.GetAxis("Vertical");
        inputVector.y = 0f;

        transform.position += (transform.forward * inputVector.x + transform.right * inputVector.z) * Time.deltaTime * movspeed;

    }
}

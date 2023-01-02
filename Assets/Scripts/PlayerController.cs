using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed=10.0f;
    private float turnSpeed=45;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is where we gte player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Code to move the vehicel in forward direction
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);

        //Code to rotate the vehicle based on the user input
        transform.Rotate(Vector3.up* Time.deltaTime * turnSpeed*horizontalInput);

    }
}

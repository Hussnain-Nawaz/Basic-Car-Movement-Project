using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontCamera : MonoBehaviour
{
    public GameObject car;
    private Vector3 offset=new Vector3(0, (float)2.5,1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = car.transform.position + offset;
    }
}

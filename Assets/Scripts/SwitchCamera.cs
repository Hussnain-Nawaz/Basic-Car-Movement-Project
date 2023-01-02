using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public Camera mainCamera;
    public Camera frontCamera;
    private bool toggle=true;
    // Start is called before the first frame update
    void Start()
    {
        frontCamera.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("c"))
        {
            if (toggle == true)
            {
                mainCamera.gameObject.SetActive(false);
                frontCamera.gameObject.SetActive(true);
                toggle = false;
            }
            else
            {
                frontCamera.gameObject.SetActive(false);
                mainCamera.gameObject.SetActive(true);
                toggle = true;
            }
        }
        
        
    }
}

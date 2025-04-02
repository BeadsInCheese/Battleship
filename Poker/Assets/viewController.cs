using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viewController : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera topView;
    public Camera firstPerson;
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("swapCam"))
        {
            topView.enabled = !topView.enabled;
            firstPerson.enabled=!topView.enabled;
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        OVRInput.Update();
        OVRInput.FixedUpdate();

        // returns a float of the Hand Trigger’s current state on the Left Oculus Touch controller.
        var LeftTrigger = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.Touch);

        // returns a float of the Hand Trigger’s current state on the Right Oculus Touch controller.
        var RightTrigger = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger, OVRInput.Controller.Touch);


        if (LeftTrigger != 0f)
        {
            SceneManager.LoadScene("Main");
        }
        else
        if (RightTrigger != 0f)
        {
            SceneManager.LoadScene("Main");
        }
    }
}

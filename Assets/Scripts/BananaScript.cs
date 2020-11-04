using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BananaScript : MonoBehaviour
{
    //this script is attached to objects so they know what to do when a button was pressed

    //this event sends out the transform of the object that was touched
    public delegate void DescriptionRequest(Transform objectPosition); //the event will send out the name of which button was pressed
    public static event DescriptionRequest onDescriptionRequest;

    private Color newColor = new Color(1.0f, 1.0f, 1.0f, 1.0f); // change this to desired color
    private Renderer rend = null;

    private void Awake()
    {
        rend = GetComponent<Renderer>(); // gives functionality for the renderer
        rend.enabled = true; //makes the rendered 3d object visible if enabled
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Finger")
        {
            Debug.Log("Object touched! Description pop up... how about rumble?");
            VibrationManager.singleton.TriggerVibration(30, 2, 255, OVRInput.Controller.Touch);


            //tell observers where the object is, the DescriptionController will make a pop up
            onDescriptionRequest?.Invoke(this.gameObject.transform);
        }
    }

    public void ColorChanger()
    {
        if ((rend != null))
        {
            newColor = new Color(Random.Range(0,1f), Random.Range(0, 1f), Random.Range(0, 1f));
            Debug.Log("New color: " + newColor);

            rend.material.color = newColor;
        }
    }


}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    private GameObject menuPrefab;
    public GameObject menuSpawnPoint;
    private Transform parentObject;


    private void Awake()
    {
        menuPrefab = Resources.Load<GameObject>($"Prefabs/Menu Object");
    }

    void OnEnable()
    {
        //sub event
        ButtonTrigger.onMenuButtonPress += ActionTriggered;
        DescriptionController.openMenu += bringUpMenu;

    }

    void OnDisable()
    {
        //unsub event
        ButtonTrigger.onMenuButtonPress -= ActionTriggered;
        DescriptionController.openMenu -= bringUpMenu;

    }

    //for when the menu is requested
    void bringUpMenu(Transform parent)
    {
        Debug.Log("Controller: Here is the menu...");
        //-----------------Create Menu Here! --------------------------
        parentObject = parent;
        Instantiate(menuPrefab, menuSpawnPoint.transform);
    }


    //for when a button is pressed
    void ActionTriggered(string whichButton)
    {
        switch (whichButton)
        {
            case "YellowButtonTrigger":
                Debug.Log("Yellow pressed - replace");
                VibrationManager.singleton.TriggerVibration(30, 2, 255, OVRInput.Controller.Touch);



                //code for replacing objects

                break;

            case "BlueButtonTrigger":
                Debug.Log("Blue pressed - color");
                VibrationManager.singleton.TriggerVibration(30, 2, 255, OVRInput.Controller.Touch);

                //code for recoloring objects
                parentObject.GetComponent<BananaScript>().ColorChanger();


                /* Debugging without VR
                                var t = GameObject.Find("Banana");

                                if (t != null)
                                {
                                    parentObject = t.transform;
                                    Debug.Log("COLOR CHANGED");

                                    parentObject.GetComponent<BananaScript>().ColorChanger();
                                }
                */


                break;
            case "RedButtonTrigger":
                Debug.Log("Red pressed - resize");
                VibrationManager.singleton.TriggerVibration(30, 2, 255, OVRInput.Controller.Touch);



                //code for resizing objects

                break;
            case "GreenButtonTrigger":
                Debug.Log("Green pressed - destroy");
                VibrationManager.singleton.TriggerVibration(30, 2, 255, OVRInput.Controller.Touch);

                //code for destroy

                break;

            default:
                Debug.Log("Can't find that button trigger");
                break;
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BananaScript : MonoBehaviour
{

    private GameObject menuPrefab;

    private void Awake()
    {
        menuPrefab = Resources.Load<GameObject>($"Prefabs/Menu Object");
    }

    void OnEnable()
    {
        //sub event
        ButtonTrigger.onMenuButtonPress += DescriptionTriggered;
    }

    void OnDisable()
    {
        //unsub event
        ButtonTrigger.onMenuButtonPress -= DescriptionTriggered;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Finger" || other.gameObject.tag == "TestCube")
        {
            //code to spawn menu if the object was touched
            Debug.Log("Banana touched!");
            Instantiate(menuPrefab);
        }
    }

    //if the event triggers then run this method
    void DescriptionTriggered(string whichButton)
    {
        switch (whichButton)
        {
            case "YellowButtonTrigger":
                Debug.Log("Yellow pressed - replace");
                //code for replacing objects

                break;
            case "BlueButtonTrigger":
                Debug.Log("Blue pressed - color");
                //code for recoloring objects

                break;
            case "RedButtonTrigger":
                Debug.Log("Red pressed - resize");
                //code for resizing objects

                break;
            case "GreenButtonTrigger":
                Debug.Log("Green pressed - destroy");
                //code for destroy

                break;

            default:
                Debug.Log("Can't find that button trigger");
                break;
        }

    }


}

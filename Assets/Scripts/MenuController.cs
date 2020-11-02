using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    private GameObject menuPrefab;

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
    void bringUpMenu()
    {
        Debug.Log("Controller: Here is the menu...");
        //-----------------Create Menu Here! --------------------------

        //Instantiate(menuPrefab);
    }


    //for when a button is pressed
    void ActionTriggered(string whichButton)
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

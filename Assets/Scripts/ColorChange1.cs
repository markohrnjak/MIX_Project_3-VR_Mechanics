using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    public Material[] materials; // allows input of material colors in a set sized array
    public Renderer rend;  
 
    private int index = 1; //initialize at 1, otherwise you have to press the cube twice to change color
 
 
    // Start is called before the first frame update
    void Start()
    {
 
        rend = GetComponent<Renderer>(); // gives functionality for the renderer
        rend.enabled = true; //makes the rendered 3d object visible if enabled
 
    }
 
    
    void ObjectTouched(object sender)
    {
        if (materials.Length == 0)//If there are no materials nothing happens.
            return;
			
		else
        {
            index += 1;//When mouse is pressed down we increment up to the next index location
 
            if (index == materials.Length + 1)//When it reaches the end of the materials it starts over.
                index = 1;
 
            print(index);//used for debugging
 
            rend.sharedMaterial = materials[index - 1]; //This sets the material color values inside the index
        }
    }
}

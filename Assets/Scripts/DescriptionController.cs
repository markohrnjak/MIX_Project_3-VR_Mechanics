using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionController : MonoBehaviour
{
    //for finding where the source object is so the window pops out/minimizes back into the object
    [SerializeField] private Transform sourceObject;


    private void OnEnable()
    {
        
    }


    //when the close button is pressed minimize the window and destroy it
    void onClose()
    {
        LeanTween.scale(gameObject, new Vector3(sourceObject.position.x, sourceObject.position.y, sourceObject.position.z), 0.5f).setOnComplete(DestroyMe);
    }

    void DestroyMe()
    {
        Destroy(gameObject);
    }


}

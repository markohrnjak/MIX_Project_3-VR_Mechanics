using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectScaler : MonoBehaviour
{
    public GameObject scaleObject;

    public Slider xSlider;
    public Slider ySlider;
    public Slider zSlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScaleObejct() {
        var scale = new Vector3(xSlider.value * 0.01f, ySlider.value * 0.01f, zSlider.value * 0.01f);
        scaleObject.transform.localScale = scale;
    }
}

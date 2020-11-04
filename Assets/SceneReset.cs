using System.Collections;
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
    private void OnCollisionReset(Collision other)
    {
        if (other.gameObject.tag == "Finger")
            {
                SceneManager.LoadScene("Main");
            }
        
    }
}

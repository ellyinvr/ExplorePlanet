using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class transEarthFPS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
    {
　　　　SceneManager.LoadScene("FPS1");

    }
       if (Input.GetKey(KeyCode.K))
    {
　　　　SceneManager.LoadScene("Earth");

    }
    }
}
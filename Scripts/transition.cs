using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transition : MonoBehaviour
{
    // Use this for initialization
    void Start () {
        Invoke("ChangeScene", 10f);
    }
    
    // Update is called once per frame
    void Update () {
        
    }
 
    void ChangeScene()
    {
        SceneManager.LoadScene("Earth");
    }
}

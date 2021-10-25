using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transOutDance : MonoBehaviour
{
    // Use this for initialization
    void Start () {
        Invoke("ChangeScene", 20f);
    }
    
    // Update is called once per frame
    void Update () {
        
    }
 
    void ChangeScene()
    {
        SceneManager.LoadScene("OutDance");
    }
}

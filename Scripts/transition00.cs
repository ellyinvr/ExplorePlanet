using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transition00 : MonoBehaviour
{
    // Use this for initialization
    void Start () {
        Invoke("ChangeScene", 6.1f);
    }
    
    // Update is called once per frame
    void Update () {
        
    }
 
    void ChangeScene()
    {
        SceneManager.LoadScene("WarpEffect");
    }
}

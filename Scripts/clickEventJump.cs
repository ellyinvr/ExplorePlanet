using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class clickEventJump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      public void MouseClicked()
    {
        Debug.Log("Clicked!");
        SceneManager.LoadScene("JumpPlanet");
    }
}

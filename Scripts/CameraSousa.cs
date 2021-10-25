using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSousa : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
    {
　　　　　　　　transform.Rotate(-1, 0, 0);
    }

  if (Input.GetKey(KeyCode.Space))
  {
    this.transform.Translate (0.0f,0.0f,1f);

  }

  if (Input.GetKey(KeyCode.S))
  {
    this.transform.Translate (0.0f,0.0f,-1f);

  }

  if (Input.GetKey("down"))
    {
    transform.Rotate(1, 0, 0);
    }

    if (Input.GetKey("right"))
    {
        transform.Rotate(0, 1, 0);
    }

    if (Input.GetKey("left"))
    {
        transform.Rotate(0, -1, 0);
    }
    }
}

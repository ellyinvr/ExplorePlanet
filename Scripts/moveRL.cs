using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    var a = Input.GetAxis("Horizontal");//左右
    // var b = Input.GetAxis("Vertical");//上下
    var force = new Vector3(a, 0f, 0f);//(x, y, z)平面方向がx,z上空方向がy
    GetComponent<Rigidbody>().AddForce(force * 2000);
    }
}

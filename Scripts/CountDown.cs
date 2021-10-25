using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    // private float time = 60;
    public float time = 60;
    // Start is called before the first frame update
    void Start()
    {
        	GetComponent<Text>().text = ((int)time).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //1秒に1ずつ減らしていく
		time -= Time.deltaTime;
		//マイナスは表示しない
		if (time < 0) time = 0;
		GetComponent<Text> ().text = ((int)time).ToString ();


    }
}

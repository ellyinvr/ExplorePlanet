using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

    //プレイヤーを変数に格納
    public GameObject Player;

    //回転させるスピード
    public float rotateSpeed = 3.0f;

    // Use this for initialization
    void Start () {
        //プレイヤー位置情報
        // Vector3 playerPos = Player.transform.position;

        //カメラを回転させる
        // transform.RotateAround(playerPos, Vector3.up, 360* rotateSpeed);
    }

    // Update is called once per frame
    void Update () {

        //回転させる角度
        // float angle = Input.GetAxis("Horizontal") * rotateSpeed;

        //プレイヤー位置情報
        Vector3 playerPos = Player.transform.position;

        //カメラを回転させる
        transform.RotateAround(playerPos, Vector3.up, rotateSpeed * Time.deltaTime);
    }
}

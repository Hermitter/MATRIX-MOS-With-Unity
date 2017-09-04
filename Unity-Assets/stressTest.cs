using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stressTest : MonoBehaviour{
    float pitch = 0f;
    float roll = 0f;
    float yaw = 0f;
    float x = 0f;
    float y = 0f;
    float z = 0f;

    // Update is called once per frame
    void Update () {

        pitch = Mathf.Floor(MATRIX.Gyroscope.pitch)*0.5f;
        //y = GameController.Gyroscope.y * Time.deltaTime * 2;

        roll = Mathf.Floor(MATRIX.Gyroscope.roll)*0.5f;
        //x = GameController.Gyroscope.x * Time.deltaTime * 2;


        transform.position = new Vector3(pitch, 2, roll);




        //Adjusted Values
        //transform.Rotate(GameController.pitch, 0, 0, Space.World);
        //Quaternion AddRot = Quaternion.identity;
        //pitch = GameController.roll * (Time.deltaTime * 2);
        //roll = GameController.pitch * (Time.deltaTime * 2) * -1;

        //AddRot.eulerAngles = new Vector3(pitch, yaw, roll);
        //transform.rotation *= AddRot;
        //Vector3 AddPos = Vector3.forward;
        //AddPos = transform.rotation * AddPos;
        //GetComponent<Rigidbody>().velocity = AddPos * (Time.deltaTime * 20.0f);//orig 2000

        //AddRot.eulerAngles = new Vector3(pitch, yaw, roll);
    }
}

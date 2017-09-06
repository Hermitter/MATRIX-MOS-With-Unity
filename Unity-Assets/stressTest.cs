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
        roll = Mathf.Floor(MATRIX.Gyroscope.roll)*0.5f;
        
        transform.position = new Vector3(pitch, 2, roll);
    }
}

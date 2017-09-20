using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rawGyroscope : MonoBehaviour{
    float pitch = 0f;
    float roll = 0f;

    // Update is called once per frame
    void Update () {
        pitch = Mathf.Floor(MATRIX.Gyroscope.pitch)*0.5f;
        roll = Mathf.Floor(MATRIX.Gyroscope.roll)*0.5f;
        //set invisible game object position to gyroscope values
        transform.position = new Vector3(pitch, 3, roll);
    }
}

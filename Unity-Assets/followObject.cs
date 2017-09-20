using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followObject : MonoBehaviour {
	//public GameObject target;
	public Transform target;
	//speed variables
    public float smoothTime = 0.5F;
    private Vector3 velocity = Vector3.zero;
	
	// Update is called once per frame
	void Update () {
		//save position of target
		Vector3 targetPosition = target.TransformPoint(new Vector3(0, 0, 0));
		//move ball to target smoothly
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);	
	}
}

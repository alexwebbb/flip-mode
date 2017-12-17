using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour {

    public Transform watchObject;

	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, watchObject.position.y, transform.position.z);
	}
}

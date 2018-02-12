using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

    public float RotateSpeed = 30f;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.forward * RotateSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(-Vector3.forward * RotateSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(Vector3.right * RotateSpeed * Time.deltaTime);
         else if (Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(-Vector3.right * RotateSpeed * Time.deltaTime);
    }
}

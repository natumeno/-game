using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {


	void FixedUpdate ()
	{
		float x =  -Input.GetAxis("Horizontal");
		float z = -Input.GetAxis("Vertical");

		Rigidbody rigidbody = GetComponent<Rigidbody>();

		// xとzに10をかけて押す力をアップ
		rigidbody.AddForce(x * 9, 0, z * 9);
	}
}
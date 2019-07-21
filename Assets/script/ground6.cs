using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground6 : MonoBehaviour {

	//オブジェクトが衝突したとき
	void OnCollisionEnter(Collision collision) {
		Physics.gravity = new Vector3(0, 9.81f, 0);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable_init : MonoBehaviour {

	public Transform Collectable;
	void Start () {

		for (int i = 0; i < 40; i ++) {
			Instantiate (Collectable, new Vector3(Random.Range(-30.0f, 30.0f), 0.5f, Random.Range(-30.0f, 30.0f)), Quaternion.identity);
		}
	}
	
}


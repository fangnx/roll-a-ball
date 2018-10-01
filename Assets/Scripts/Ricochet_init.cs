using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ricochet_init : MonoBehaviour {

	public Transform Ricochet;

	void Start () {

		for (int i = 0; i < 10; i ++) {
			Instantiate (Ricochet, new Vector3(Random.Range(-30.0f, 30.0f), 1.0f, Random.Range(-30.0f, 30.0f)), Quaternion.identity);
		}
	}
	
}
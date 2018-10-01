using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	void Update () {
		Vector3 xyz = new Vector3(10 * Random.Range(0, 100.0f), 10 * Random.Range(0, 100.0f), 10 * Random.Range(0, 100.0f));
		transform.Rotate (xyz * Time.deltaTime);
	}
}

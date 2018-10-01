using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText();
		winText.text = "";
	}

	void Update(){
		ReloadLevel();
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);
	}


	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag("Collectable")){
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText();
		}
		else if (other.gameObject.CompareTag("Ricochet")){ 
			// float current_x = rb.position.x;
			// float current_z = rb.position.z;

			// rb.velocity = Vector3.zero;
			// rb.angularVelocity = Vector3.zero;

			// Vector3 reversed_movement = new Vector3 (-current_x, 0.0f, -current_z);
			// rb.AddForce (reversed_movement * speed * 10);

			rb.velocity = -1 * rb.velocity;	


		}
	}

	void SetCountText(){
		countText.text = "Count " + count.ToString ();
		if(count >= 12){
			winText.text = "You Win!";
		}

	}

	void ReloadLevel(){
		if (Input.GetKey (KeyCode.R)){

			Application.LoadLevel (Application.loadedLevel);
		}
	}

}



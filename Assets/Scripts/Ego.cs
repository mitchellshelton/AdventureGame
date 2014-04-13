using UnityEngine;
using System.Collections;

/**
 * Player controller and behavior 
 */
public class Ego : MonoBehaviour {

	// Speed of the player
	public Vector2 speed = new Vector2(1, 1);

	// Store the movement
	private Vector2 movement;
	private float egoY;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		// Retrive axis information
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		// Movement per direction
		movement = new Vector2(speed.x * inputX, speed.y * inputY);

		// Create a dynamic sprite sort order for object layers
		// Get the Character Y position
		egoY = transform.position.y;
		// Set the sort order based on the Y position
		if (egoY <= 2.0 && egoY > 1.9) {
			GetComponent<SpriteRenderer>().sortingLayerName = "0";
		}
		else if (egoY <= 1.9 && egoY > 1.8) {
			GetComponent<SpriteRenderer>().sortingLayerName = "1";
		}
		else if (egoY <= 1.8 && egoY > 1.7) {
			GetComponent<SpriteRenderer>().sortingLayerName = "2";
		}
		else if (egoY <= 1.7 && egoY > 1.6) {
			GetComponent<SpriteRenderer>().sortingLayerName = "3";
		}
		else if (egoY <= 1.6 && egoY > 1.5) {
			GetComponent<SpriteRenderer>().sortingLayerName = "4";
		}
		else if (egoY <= 1.5 && egoY > 1.4) {
			GetComponent<SpriteRenderer>().sortingLayerName = "5";
		}
		else if (egoY <= 1.4 && egoY > 1.3) {
			GetComponent<SpriteRenderer>().sortingLayerName = "6";
		}
		else if (egoY <= 1.3 && egoY > 1.2) {
			GetComponent<SpriteRenderer>().sortingLayerName = "7";
		}
		else if (egoY <= 1.2 && egoY > 1.1) {
			GetComponent<SpriteRenderer>().sortingLayerName = "8";
		}
		else if (egoY <= 1.1 && egoY > 1.0) {
			GetComponent<SpriteRenderer>().sortingLayerName = "9";
		}
		else if (egoY <= 1.0 && egoY > 0.9) {
			GetComponent<SpriteRenderer>().sortingLayerName = "10";
		}
		else if (egoY <= 0.9 && egoY > 0.8) {
			GetComponent<SpriteRenderer>().sortingLayerName = "11";
		}
		else if (egoY <= 0.8 && egoY > 0.7) {
			GetComponent<SpriteRenderer>().sortingLayerName = "12";
		}
		else if (egoY <= 0.7 && egoY > 0.6) {
			GetComponent<SpriteRenderer>().sortingLayerName = "13";
		}
		else if (egoY <= 0.6 && egoY > 0.5) {
			GetComponent<SpriteRenderer>().sortingLayerName = "14";
		}
		else if (egoY <= 0.5 && egoY > 0.4) {
			GetComponent<SpriteRenderer>().sortingLayerName = "15";
		}
		else {
			GetComponent<SpriteRenderer>().sortingLayerName = "0";
		}

	}

	void FixedUpdate() {
		// Move the game object
		rigidbody2D.velocity = movement;
	}
}

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        if (Input.GetKey(KeyCode.UpArrow))//up
        {
            rb.AddForce(movement * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))//down
        {
            rb.AddForce(movement * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))//left
        {
            rb.AddForce(movement * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))//right
        {
            rb.AddForce(movement * speed);
        }
        
	}
}
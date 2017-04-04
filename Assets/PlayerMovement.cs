using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float jumpForce = 5;
    public float speed = 2;
    public Rigidbody body;

	void Start () {
        body = GetComponent<Rigidbody>();
	}
	

	void Update () {

	if (Input.GetKey(KeyCode.D))
        {
            body.AddForce(transform.right * speed);
        }
    if (Input.GetKey(KeyCode.A))
        {
            body.AddForce(-transform.right * speed);
        }
    if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(transform.up * jumpForce);
        }
	}
}

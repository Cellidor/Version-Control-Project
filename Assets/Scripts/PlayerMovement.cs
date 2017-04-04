using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    [Range(20f,40f)]
    public float jumpForce = 20;
    [Range(1f,5f)]
    public float speed = 2;
    [Range(1, 3)]
    public int allowedJumps = 1 ;


    private Rigidbody body;
    private string currentMove;
    private string lastMove;
    private int jumpCount;

	void Start () {
        body = GetComponent<Rigidbody>();
	}
	

	void Update () {

	if (Input.GetKey(KeyCode.D))
        {
            currentMove = "D";
            if (currentMove != lastMove)
            {
                body.velocity = new Vector3 (body.velocity.x/1.5f,body.velocity.y);
                lastMove = currentMove;
            }
            body.AddForce(transform.right * speed);
        }
    if (Input.GetKey(KeyCode.A))
        {
            currentMove = "A";
            if (currentMove != lastMove)
            {
                body.velocity = new Vector3(body.velocity.x / 1.5f, body.velocity.y);
                lastMove = currentMove;
            }
            body.AddForce(-transform.right * speed);
        }
    if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount < allowedJumps)
            {
                body.AddForce(transform.up * jumpForce);
                jumpCount++;
            }

        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            jumpCount = 0;
        }
    } 
}

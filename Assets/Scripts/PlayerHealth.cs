using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    public float health;
    public Vector3 checkPoint;
	void Start () {
        checkPoint = gameObject.transform.position; 
	}
	
	void Update () {
	
	}


    void HealthLoss (int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Respawn();
        }
    }

    void SetCheckpoint(Vector3 location)
    {

    }

    void Respawn()
    {
        gameObject.transform.position = checkPoint;
        health = 100;
    }
}

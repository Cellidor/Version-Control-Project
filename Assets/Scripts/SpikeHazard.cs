using UnityEngine;
using System.Collections;

public class SpikeHazard : MonoBehaviour {

    [Range(10, 25)]
    public int damage = 10;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SendMessage("HealthLoss", damage);
        }
    }
}

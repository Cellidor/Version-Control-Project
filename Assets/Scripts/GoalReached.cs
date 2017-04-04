using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoalReached : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Assignment_01");
        }
    }
}

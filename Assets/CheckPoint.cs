using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {

    public AudioClip ding;
    AudioSource audioS;
    private bool gotCheckpoint;

	void Start () {
        audioS = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !gotCheckpoint)
        {
            audioS.PlayOneShot(ding);
            other.gameObject.SendMessage("SetCheckpoint", gameObject.transform.position);
            gotCheckpoint = true;
        }
    }
}

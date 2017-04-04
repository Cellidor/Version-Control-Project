using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    private Vector3 cameraPos;

    [Range(2,10)]
    public float followSpeed = 2;

	void Start () {
        
        cameraPos = gameObject.transform.position;
	}

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, player.position, Time.deltaTime * 3);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, cameraPos.z);
    }
}

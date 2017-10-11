using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAudiosourceScript : MonoBehaviour {

    GameObject player1Pad;
    public GameObject ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ball == null)
        {
            Destroy(gameObject);
        }
        transform.position = new Vector3(ball.transform.position.x, player1Pad.transform.position.y);
        GetComponent<AudioSource>().panStereo = Mathf.Sign(transform.position.x - player1Pad.transform.position.x);
	}
    public void setVariables(GameObject pad, GameObject theBall) {
        player1Pad = pad;
        ball = theBall;
    }
}

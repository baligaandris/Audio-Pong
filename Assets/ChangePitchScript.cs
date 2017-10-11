using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePitchScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<AudioSource>().pitch = GetComponent<BallAudiosourceScript>().ball.transform.position.y/15;
	}
}

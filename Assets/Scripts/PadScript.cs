using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadScript : MonoBehaviour {

    public float speed = 3f;
    public int playerNumber;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        GetComponent<Rigidbody2D>().velocity = new Vector3(Input.GetAxis("Horizontal"+playerNumber.ToString())*speed, 0);
        
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="ball")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}

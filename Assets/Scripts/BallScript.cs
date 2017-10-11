using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    Rigidbody2D rb;
    bool inPlay = false;
    public GameObject myPad;
    public float speed = 3;
    float y = 1;
    public GameObject ballAudiosourcePrefab;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        GameObject ballAudioSource = Instantiate(ballAudiosourcePrefab);
        ballAudioSource.GetComponent<BallAudiosourceScript>().setVariables(myPad, gameObject);
	}

    // Update is called once per frame

	void Update () {
        if (!inPlay)
        {
            transform.position = new Vector3(myPad.transform.position.x, transform.position.y);
            if (Input.GetButton("Jump"))
            {
                if (myPad.tag == "Player1")
                {
                    y = speed;
                }
                else {
                    y = -speed;
                }

                rb.AddForce(new Vector2(Random.Range(-1f, 1f), y), ForceMode2D.Impulse);
                inPlay = true;
            }
        }

	}
    public void SetMyPad(GameObject startingPad) {
        myPad = startingPad;

    }
}

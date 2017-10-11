using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GoalScript : MonoBehaviour {

    public GameObject myPad;
    public GameObject ballPrefab;
    private GameMasterScript gameMaster;


	// Use this for initialization
	void Start () {
        gameMaster = GameObject.FindGameObjectWithTag("gameMaster").GetComponent<GameMasterScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            Destroy(collision.gameObject);
            GameObject newBall = Instantiate(ballPrefab, myPad.transform.GetChild(0).transform.position, Quaternion.identity);
            newBall.GetComponent<BallScript>().SetMyPad(myPad);
            if (gameObject.tag == "Player1")
            {
                gameMaster.UpdateScore(1, 1);
            }
            else {
                gameMaster.UpdateScore(1, 2);
            }

        }
    }
}

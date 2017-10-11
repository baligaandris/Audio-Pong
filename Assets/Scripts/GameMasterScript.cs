using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMasterScript : MonoBehaviour {

    public int player1score=0;
    public int player2score = 0;
    public GameObject player1scoreText;
    public GameObject player2scoreText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateScore(int scoreToAdd,int whichPlayerScored) {
        if (whichPlayerScored == 1)
        {
            player1score += scoreToAdd;
            player1scoreText.GetComponent<Text>().text = player1score.ToString();
        }
        else {
            player2score += scoreToAdd;
            player2scoreText.GetComponent<Text>().text = player2score.ToString();
        }

    }
}

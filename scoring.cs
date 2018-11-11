using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour {
    public score_control score_Control;
    public Text scoreBoard;
    // Use this for initialization
    void Start () {
        scoreBoard.text = "Number of balls fired: "+ "\n Number of balls missed:" + score_Control.fail_count;

    }
	
	// Update is called once per frame
	void Update () {
        scoreBoard.text = "Number of balls fired: " + "\n Number of balls missed:" + score_Control.fail_count;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerMovement : MonoBehaviour {

    private int secondsToDestroy = 12;

    void Awake()
    {
        Destroy(this.gameObject, secondsToDestroy);  
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (transform.position.x < -7.2f)
        {
            Destroy(this.gameObject);
        }

	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("hit by u");
            FindObjectOfType<AudioManager>().Play("HitBall");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_control : MonoBehaviour {
    public int fail_count;
	// Use this for initialization
	void Start () {
        fail_count = 0;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        fail_count++;
        FindObjectOfType<AudioManager>().Play("Boo");
        Debug.Log("I was hit, I failed "+ fail_count);
    }
}

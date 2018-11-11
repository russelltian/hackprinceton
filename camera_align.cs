using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_align : MonoBehaviour {
    public Transform camera_on_head;
	// Use this for initialization
	void Start () {
        camera_on_head.position = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        camera_on_head.position = transform.position;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    [Range(0f, 60f)]
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (CrossPlatformInputManager.GetAxis("Horizontal") != 0) {

            transform.Translate(Vector3.right * CrossPlatformInputManager.GetAxis("Horizontal") * speed * Time.deltaTime);
        }		
	}
}

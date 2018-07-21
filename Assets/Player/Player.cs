using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.CrossPlatformInput;

public class Player : NetworkBehaviour {

    [Range(0f, 60f)]
    public float speed;

    Camera myCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if ( ! isLocalPlayer) {
            return;
        }
        Camera[] cameras = FindObjectsOfType<Camera>();
        foreach (Camera camera in cameras) {
            if (camera != myCamera) {
                camera.gameObject.SetActive(false);
            }
        }

        if (CrossPlatformInputManager.GetAxis("Horizontal") != 0) {

            transform.Translate(Vector3.right * CrossPlatformInputManager.GetAxis("Horizontal") * speed * Time.deltaTime);
        }
        if (CrossPlatformInputManager.GetAxis("Vertical") != 0) {

            transform.Translate(Vector3.forward * CrossPlatformInputManager.GetAxis("Vertical") * speed * Time.deltaTime);
        }
    }

    public override void OnStartLocalPlayer () {

        myCamera = GetComponentInChildren<Camera>();
    }
}

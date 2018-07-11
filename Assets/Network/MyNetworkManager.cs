using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MyStartHost () {

        Debug.Log(Time.timeSinceLevelLoad + ": Host attempting to start.");
        StartHost();
    }

    public override void OnStartHost () {

        Debug.Log(Time.timeSinceLevelLoad + ": Host started.");
    }

    public override void OnStartClient (NetworkClient myClient) {

        Debug.Log(Time.timeSinceLevelLoad + ": Client start requested.");
        InvokeRepeating("ConnectionWaitingDisplay", 0f, 1f);
    }

    public override void OnClientConnect(NetworkConnection myConn) {

        CancelInvoke();
        Debug.Log(Time.timeSinceLevelLoad + ": Client has connected to IP: " + myConn.address);
    }

    void ConnectionWaitingDisplay () {

        Debug.Log(".");
    }
}

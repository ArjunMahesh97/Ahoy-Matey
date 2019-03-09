using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {


	// Use this for initialization
	void Start () {
	}

	public void MyStartHost(){
		Debug.Log (Time.timeSinceLevelLoad+"starting host");
		StartHost ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void OnStartHost(){
		Debug.Log (Time.timeSinceLevelLoad+"host started");
	}
	public override void OnStartClient(NetworkClient myClient){
		Debug.Log (Time.timeSinceLevelLoad+"client start req");
	}

	public override void OnClientConnect(NetworkConnection conn){
		Debug.Log (Time.timeSinceLevelLoad + "client connected to ip :" + conn.address);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {


	// Use this for initialization
	void Start () {
	}

	public void MyStartHost(){
		Debug.Log (Time.timeSinceLevelLoad);
		StartHost ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void OnStartHost(){
		Debug.Log (Time.timeSinceLevelLoad);
	}
}

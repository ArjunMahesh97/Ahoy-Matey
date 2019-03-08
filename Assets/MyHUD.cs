using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyHUD : MonoBehaviour {

	private NetworkManager networkManager;

	// Use this for initialization
	void Start () {
		networkManager = GetComponent<NetworkManager> ();
	}

	public void MyStartHost(){
		Debug.Log (Time.timeSinceLevelLoad);
		networkManager.StartHost ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnStartHost(){
		Debug.Log (Time.timeSinceLevelLoad);
	}
}

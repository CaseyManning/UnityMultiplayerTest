using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class CameraScript : NetworkBehaviour {

	GameObject parent;

	// Use this for initialization
	void Start () {

		parent = transform.parent.gameObject;

		if(((NetworkBehaviour)parent.GetComponent("FirstPersonController")).isLocalPlayer){
			((Camera) GetComponent<Camera>()).enabled = true;
		}
		else{
			((Camera) GetComponent<Camera>()).enabled = false;
		}
	}

	private void Update() {
		if(((NetworkBehaviour)parent.GetComponent("FirstPersonController")).isLocalPlayer){
			((Camera) GetComponent<Camera>()).enabled = true;
		}
		else{
			((Camera) GetComponent<Camera>()).enabled = false;
		}
	}
}



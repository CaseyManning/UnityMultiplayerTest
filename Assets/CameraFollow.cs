using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class CameraFollow : MonoBehaviour {

	GameObject player;

	// Use this for initialization
	void Start () {
		GameObject.FindGameObjectsWithTag ("Player");
		if (((NetworkBehaviour)player.GetComponent ("FirstPersonController")).isLocalPlayer) {

		}
			
	}
	
	// Update is called once per frame
	void Update () {
		//transform = player.transform;
	}
}

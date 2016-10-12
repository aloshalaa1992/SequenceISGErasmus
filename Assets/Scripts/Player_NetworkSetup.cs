using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Player_NetworkSetup : NetworkBehaviour {

	[SerializeField] Camera FPSCharacterCam; 
	[SerializeField] AudioListener audioListener;

	// Use this for initialization
	void Start ()
	{
		transform.position = new Vector3 (250, 2, 250);
		if(isLocalPlayer)
		{
			GameObject.Find ("Main Camera").SetActive (false);
			GetComponent<CharacterController> ().enabled = true;

			GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().enabled = true;
			FPSCharacterCam.enabled = true; 
			audioListener.enabled = true;

//			GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl  > ().enabled = true;
//			GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter  > ().enabled = true;
		}

	}
}
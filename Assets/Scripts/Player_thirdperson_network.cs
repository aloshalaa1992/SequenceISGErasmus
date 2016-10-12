using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Player_thirdperson_network : NetworkBehaviour {

	[SerializeField] Camera FPSCharacterCam; 
	[SerializeField] AudioListener audioListener;

	// Use this for initialization
	public override void OnStartLocalPlayer ()
	{
		transform.position = new Vector3 (250, 2, 250);
		if(isLocalPlayer)
		{
			GameObject.Find ("Main Camera").SetActive (false);
			GetComponent<CharacterController> ().enabled = false;

			GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().enabled = true;
			FPSCharacterCam.enabled = true; 
			audioListener.enabled = true;

			GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl  > ().enabled = true;
			GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter  > ().enabled = true;

//			Renderer[] rens = GetComponentsInChildren<Renderer> ();
//			foreach (Renderer ren in rens)
//				ren.enabled = false;

			GetComponent<NetworkAnimator> ().SetParameterAutoSend (0, true);

		}

	}

	public override void PreStartClient (){
		

			GetComponent<NetworkAnimator> ().SetParameterAutoSend (0, true);

	}






}
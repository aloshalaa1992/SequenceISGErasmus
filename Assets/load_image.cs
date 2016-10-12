using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

//using System.Collections.Generic;
//using System;
//using System.Linq;

public class load_image : MonoBehaviour {

	// Use this for initialization

	void Start () {

			
			var obj = GameObject.FindWithTag ("PhotoManager");
			obj.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load ("1",typeof(Sprite));
//				myImageComponent = GetComponent<Image>();
//				tex = (Texture2D)Resources.Load("Assets/Resources/1.png");
//				damageImage = GameObject.FindWithTag ("deneme_image");
//
//				damageImage.GetComponen = tex;

	}

	// Update is called once per frame
	void Update () {
		//		object material;
		//		int pic_number;
		//
		//
		//		if (PhotonNetwork.player.customProperties.TryGetValue (PhotonPlayerExtensions.materialProp, out material)) {
		//			pic_number = (int)material;
		//		} else {
		//			pic_number = 0;
		//		};
		//			
		//
		//		string pic_number2 = pic_number.ToString();
		//		pic_number2 = "pic_" + pic_number2;
		//		gameObject.GetComponent<Image> ().sprite = (Sprite)Resources.Load (pic_number2,typeof(Sprite));
	}
}

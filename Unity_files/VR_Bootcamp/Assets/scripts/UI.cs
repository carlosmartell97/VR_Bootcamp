using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	public Sprite arrowImage;
	public Image arrowPic;

	public void buttonForward(){
		Debug.Log("move FORWARD!");
		//GameObject.Find("sequence1").GetComponent<ImageChanger>().spriteToChangeTo = arrowImage;
		GameObject.Find("sequence1").GetComponent<ImageChanger>().ChangeImage(arrowImage);
		//GameObject.Find("sequence1").GetComponent<ImageChanger>().ChangeImage(arrowPic);
	}

	public void buttonRight(){
		Debug.Log("move RIGHT!");
	}

	public void buttonLeft(){
		Debug.Log("move LEFT!");
	}

}

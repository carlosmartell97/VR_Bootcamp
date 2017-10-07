using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	bool move, right, left, forward;

	void Start(){
		
	}

	void Update(){
		if(move){
			if(right){

			}
			else if(left){

			}
			else if(forward){

			}
		}
	}

	public Sprite arrowSprite;
	//public Image arrowPic;

	public void buttonForward(){
		int steps = GameObject.Find("Camera").GetComponent<mainCamera>().steps;
		GameObject.Find("Canvas").transform.GetChild(GameObject.Find("Camera").GetComponent<mainCamera>().steps+3).GetChild(0).gameObject.GetComponent<Image>().enabled = true;
		GameObject.Find("Camera").GetComponent<mainCamera>().instructions[steps] = 1;
		GameObject.Find("Camera").GetComponent<mainCamera>().steps++;
		Debug.Log("move FORWARD!");
		Debug.Log("steps:"+steps);
	}

	public void buttonLeft(){
		int steps = GameObject.Find("Camera").GetComponent<mainCamera>().steps;
		GameObject.Find("Canvas").transform.GetChild(GameObject.Find("Camera").GetComponent<mainCamera>().steps+3).GetChild(1).gameObject.GetComponent<Image>().enabled = true;
		GameObject.Find("Camera").GetComponent<mainCamera>().instructions[steps] = 2;
		GameObject.Find("Camera").GetComponent<mainCamera>().steps++;
		Debug.Log("move LEFT!");
	}

	public void buttonRight(){
		int steps = GameObject.Find("Camera").GetComponent<mainCamera>().steps;
		GameObject.Find("Canvas").transform.GetChild(GameObject.Find("Camera").GetComponent<mainCamera>().steps+3).GetChild(2).gameObject.GetComponent<Image>().enabled = true;
		GameObject.Find ("Camera").GetComponent<mainCamera>().instructions[steps] = 3;
		GameObject.Find("Camera").GetComponent<mainCamera>().steps++;
		Debug.Log("move RIGHT!");
	}

	public void startButton(){
		int[] ins = GameObject.Find("Camera").GetComponent<mainCamera>().instructions;
		Debug.Log("STARTA!");
		move = true;
		for(int i=0; i<6; i++){
			Debug.Log("at index:"+ins[i]);
			if(ins[i]==1){
				GameObject.Find("Sphere").transform.Translate(0,0,3,Space.Self);
				StartCoroutine(waitSeconds());
			}
			else if(ins[i]==2){
				GameObject.Find("Sphere").transform.Rotate(0,-90,0);
				StartCoroutine(waitSeconds());
			}
			else if(ins[i]==3){
				right = true;
				GameObject.Find("Sphere").transform.Rotate(0,90,0);
				StartCoroutine(waitSeconds());
			}
		}
	}

	IEnumerator waitSeconds(){
		while (true) {
			yield return new WaitForSeconds(10.0f);
		}
	}
}

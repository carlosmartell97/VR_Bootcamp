using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainCamera : MonoBehaviour {

	public int xVelocity, yVelocity;
	public GameObject level;
	public int steps;
	public int[] instructions;

	// Use this for initialization
	void Start () {
		instructions = new int[6];
		for(int i=3; i<9; i++){
			for(int j=0; j<3; j++){
				GameObject.Find ("Canvas").transform.GetChild (i).GetChild (j).gameObject.GetComponent<Image> ().enabled = false;
			}
		}
		this.steps = 0;
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		this.transform.Translate(horizontal*xVelocity*Time.deltaTime,0,vertical*yVelocity*Time.deltaTime/*,Space.World*/);
		this.transform.LookAt(level.transform.position);
	}
}

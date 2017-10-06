using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCamera : MonoBehaviour {

	public int xVelocity, yVelocity;
	public GameObject level;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		this.transform.Translate(horizontal*xVelocity*Time.deltaTime,0,vertical*yVelocity*Time.deltaTime/*,Space.World*/);
		this.transform.LookAt(level.transform.position);
	}
}

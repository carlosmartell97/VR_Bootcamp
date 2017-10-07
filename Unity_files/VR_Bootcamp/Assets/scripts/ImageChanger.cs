using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
	//public Sprite spriteToChangeTo;

	public void ChangeImage(Sprite myImageToUpdate)
	{
		//myImageToUpdate.sprite = spriteToChangeTo;
		GetComponent<Image>().sprite = myImageToUpdate;
		//GetComponent<Button>().image.sprite = myImageToUpdate;
		//GetComponent<Button>().image = myImageToUpdate;
		Debug.Log("ASDF ASDF");
	}
}

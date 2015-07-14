using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]

public class VIDEO : MonoBehaviour {
	public MovieTexture movTexture;
	void Start() {
		GetComponent<Renderer>().material.mainTexture = movTexture;
		movTexture.Play();
	}
	
	// Update is called once per frame

}

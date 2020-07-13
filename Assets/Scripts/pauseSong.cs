using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseSong : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

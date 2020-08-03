using UnityEngine;
using System.Collections; 

public class BGM : MonoBehaviour {
	public AudioSource myAudioSource; 

	public static GameObject bgmobject; 

	bool muted; 

	void Awake () {
		if (bgmobject) {
			return;
		}
 
		myAudioSource.Play();
		bgmobject = gameObject;
	}

	void Update () {
		if (muted) {
			myAudioSource.volume = 0;
		} else if (!muted) { 
			myAudioSource.volume = 1;
		}
	
	}

	public void Mute () {
		muted = !muted;
	}
}
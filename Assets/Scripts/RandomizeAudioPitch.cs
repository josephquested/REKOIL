using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeAudioPitch : MonoBehaviour {

	public float minPitch;
	public float maxPitch;

	void Start ()
	{
		GetComponent<AudioSource>().pitch = Random.Range(minPitch, maxPitch);
	}
}

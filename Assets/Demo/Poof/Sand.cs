using UnityEngine;
using System.Collections;

public class Sand : MonoBehaviour {
	private ParticleSystem effect;
	private AudioSource audioSource;
	private bool done = false;
	// Use this for initialization
	void Start () {
		effect = GetComponent<ParticleSystem>();
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y <= 0.2 && !done){
			effect.Play();
			audioSource.Play();
			done = true;
		}
	}
}

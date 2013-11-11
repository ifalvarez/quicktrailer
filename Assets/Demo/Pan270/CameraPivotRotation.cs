using UnityEngine;
using System.Collections;

public class CameraPivotRotation : MonoBehaviour {
	private float speed = 30f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(transform.position, transform.up, Time.deltaTime * -speed);
	}
}

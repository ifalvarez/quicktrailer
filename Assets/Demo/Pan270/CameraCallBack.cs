using UnityEngine;
using System.Collections;

public class CameraCallBack : MonoBehaviour {
	private float speed = 0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		camera.transform.position = new Vector3(camera.transform.position.x + speed * Time.deltaTime, 
			camera.transform.position.y + speed/3 * Time.deltaTime, camera.transform.position.z);
		transform.LookAt(transform.parent);
	}
}

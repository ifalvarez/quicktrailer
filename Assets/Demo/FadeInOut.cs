using UnityEngine;
using System.Collections;

public class FadeInOut : MonoBehaviour {
	
	public Texture2D fadeOutTexture;
	public float fadeSpeed = 0.3f;
	public int drawDepth = -1000;
  
	private float alpha = 1.0f; 
 	private int fadeDir = -1;
  
	void OnGUI(){
		alpha += fadeDir * fadeSpeed * Time.deltaTime;	
		alpha = Mathf.Clamp01(alpha);	
		GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.depth = drawDepth;
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);
	}
 
	void fadeIn(){
		fadeDir = -1;
		//Debug.Log("fadeIn");
	}
  
	void fadeOut(){
		fadeDir = 1;
		//Debug.Log("fadeOut");
	}
 
	void Start(){
		alpha=1;
		fadeIn();
	}
}

using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {
	
	public int[] sceneIndexes;
	public Texture2D fadeTexture;
	private float nextTransitionTime = 0;
	private int currentScene = -1;
	private float currentSceneDuration = 0;
	
	void Awake() {
		DontDestroyOnLoad(this);
	}
	
	void Start () {
		
	}
	
	void Update () {
		if(Time.time >= nextTransitionTime - 1f && Application.loadedLevel != 1){
			Camera.main.SendMessage("fadeOut");
		}
		if(Time.time >= nextTransitionTime && Application.loadedLevel != 1){
			currentScene++;
			if(currentScene < sceneIndexes.Length){
				Application.LoadLevel(sceneIndexes[currentScene]);
			}else{
				Application.LoadLevel(1);
			}
		}
	}
	
	void OnLevelWasLoaded(){
		Debug.Log("level loaded");
		GameObject sceneInfo = GameObject.Find("SceneInfo");
		if(sceneInfo != null){
			currentSceneDuration = sceneInfo.GetComponent<SceneInfo>().duration;
			nextTransitionTime = Time.time + currentSceneDuration;
		}
		if(Application.loadedLevel != 1){
			Camera.main.gameObject.AddComponent("FadeInOut");
			Camera.main.gameObject.GetComponent<FadeInOut>().fadeOutTexture = fadeTexture;
			Camera.main.SendMessage("fadeIn");
		}
	}
}

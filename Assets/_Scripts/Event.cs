﻿using UnityEngine;
using System.Collections;

public class Event : MonoBehaviour {

	public SceneManager sceneManager;

	void fireEvent(int eventIndex){
		switch (eventIndex) {
		case 0:
			sceneManager.nextCamera();
			break;
		case 1:
			sceneManager.enableActor(SceneManager.Actor.elder);
			sceneManager.nextCamera();
			break;
		case 2:
			sceneManager.nextCamera();
			GameObject dog = sceneManager.getActor(SceneManager.Actor.dog);
			dog.GetComponent<DogController>().setControllable(true);
			dog.GetComponentInParent<MouseLook>().enabled = true;
			//dog.transform.parent.gameObject.GetComponentInChildren<MouseLook>().enabled = true;
			GameObject.Find("FPS Camera").GetComponent<MouseLook>().enabled = true;
			break;
		case 3:
			GameObject sceneSwoop = GameObject.Find("Scene Swoop");
			sceneSwoop.transform.parent = null;
			sceneSwoop.GetComponent<Animator>().SetTrigger("Go");
			break;
		case 4:
			sceneManager.nextCamera();
			sceneManager.getActor(SceneManager.Actor.elder).GetComponent<ElderController>().doubleSpeed();
			break;
		case 5:
			sceneManager.nextCamera();
			sceneManager.getActor(SceneManager.Actor.elder).GetComponent<ElderController>().halfSpeed();
			break;
		}
		
	}
}
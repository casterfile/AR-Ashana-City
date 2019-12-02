using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

	public GameObject Maps, MarkerObjects, Photo360,BackButton, AseanaButton,SendInfo;

	// Use this for initialization
	void Start () {
		Maps.SetActive(false);
		MarkerObjects.SetActive(true);
		Photo360.SetActive(false);
		BackButton.SetActive(false);
		AseanaButton.SetActive(true);
		SendInfo.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void FuncMaps(){
		Maps.SetActive(true);
		MarkerObjects.SetActive(false);
		Photo360.SetActive(false);
		BackButton.SetActive(true);
		AseanaButton.SetActive(false);
		SendInfo.SetActive(false);
	}

	public void FuncMarkerObjects(){
		Maps.SetActive(false);
		MarkerObjects.SetActive(true);
		Photo360.SetActive(false);
		BackButton.SetActive(false);
		AseanaButton.SetActive(true);
		SendInfo.SetActive(false);
	}

	public void FuncBackButton(){
		Maps.SetActive(false);
		MarkerObjects.SetActive(true);
		Photo360.SetActive(false);
		BackButton.SetActive(false);
		AseanaButton.SetActive(true);
		SendInfo.SetActive(false);
	}
	public void FuncSendInfo(){
		Maps.SetActive(false);
		MarkerObjects.SetActive(false);
		Photo360.SetActive(false);
		BackButton.SetActive(false);
		AseanaButton.SetActive(false);
		SendInfo.SetActive(true);
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

	public string Name;
	public GameObject Photo360,List360Photo;
	public GameObject MarkerObjects, Maps, AseanaButton,SendInfo,BackButton;

	public Texture[] textures;
	public Renderer rend;

	// Use this for initialization
	void Start () {
		MarkerObjects.SetActive(true);
		Photo360.SetActive(false);
		List360Photo.SetActive(false);
		Maps.SetActive(false);

	}

	void OnMouseDown()
    {
    	if(Name == "FuncButton01"){FuncButton01();}  
		if(Name == "FuncButton02"){FuncButton02();}  
		if(Name == "FuncButton03"){FuncButton03();}  
		if(Name == "FuncButton04"){FuncButton04();}  
		if(Name == "FuncButton05"){FuncButton05();}  
		if(Name == "FuncButton06"){FuncButton06();}  
		if(Name == "FuncButton07"){FuncButton07();}  
    }

    public void FuncButton01(){
		// Application.LoadLevel ("Scene03_360");
		Photo360.SetActive(true);
		List360Photo.SetActive(true);
		MarkerObjects.SetActive(false);
		Maps.SetActive(false);
		AseanaButton.SetActive(false);
		SendInfo.SetActive(true);
		BackButton.SetActive(true);

		rend.material.mainTexture = textures[0];
	}

	public void FuncButton02(){
		// Application.LoadLevel ("Scene03_360");
		Photo360.SetActive(true);
		List360Photo.SetActive(true);
		MarkerObjects.SetActive(false);
		Maps.SetActive(false);
		AseanaButton.SetActive(false);
		SendInfo.SetActive(true);
		BackButton.SetActive(true);

		rend.material.mainTexture = textures[1];
	}

	public void FuncButton03(){
		// Application.LoadLevel ("Scene03_360");
		Photo360.SetActive(true);
		List360Photo.SetActive(true);
		MarkerObjects.SetActive(false);
		Maps.SetActive(false);
		AseanaButton.SetActive(false);
		SendInfo.SetActive(true);
		BackButton.SetActive(true);

		rend.material.mainTexture = textures[2];
	}

	public void FuncButton04(){
		// Application.LoadLevel ("Scene03_360");
		Photo360.SetActive(true);
		List360Photo.SetActive(true);
		MarkerObjects.SetActive(false);
		Maps.SetActive(false);
		AseanaButton.SetActive(false);
		SendInfo.SetActive(true);
		BackButton.SetActive(true);

		rend.material.mainTexture = textures[3];
	}

	public void FuncButton05(){
		// Application.LoadLevel ("Scene03_360");
		Photo360.SetActive(true);
		List360Photo.SetActive(true);
		MarkerObjects.SetActive(false);
		Maps.SetActive(false);
		AseanaButton.SetActive(false);
		SendInfo.SetActive(true);
		BackButton.SetActive(true);

		rend.material.mainTexture = textures[4];
	}

	public void FuncButton06(){
		// Application.LoadLevel ("Scene03_360");
		Photo360.SetActive(true);
		List360Photo.SetActive(true);
		MarkerObjects.SetActive(false);
		Maps.SetActive(false);
		AseanaButton.SetActive(false);
		SendInfo.SetActive(true);
		BackButton.SetActive(true);

		rend.material.mainTexture = textures[5];
	}

	public void FuncButton07(){
		// Application.LoadLevel ("Scene03_360");
		Photo360.SetActive(true);
		List360Photo.SetActive(true);
		MarkerObjects.SetActive(false);
		Maps.SetActive(false);
		AseanaButton.SetActive(false);
		SendInfo.SetActive(true);
		BackButton.SetActive(true);

		rend.material.mainTexture = textures[6];
	}
}

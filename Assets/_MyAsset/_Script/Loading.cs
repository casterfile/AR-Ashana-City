using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(ExecuteSmile(3));
	}
	IEnumerator ExecuteSmile(float time)
	{

		yield return new WaitForSeconds(time);
		Application.LoadLevel ("Scene02_AR");
	}
}

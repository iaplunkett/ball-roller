using UnityEngine;
using System.Collections;

public class CubeSpinner : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (new Vector3 (45.0f, 45.0f, 45.0f) * Time.deltaTime);
	}
}

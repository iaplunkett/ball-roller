using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject ball;
	private Vector3 distance;

	// Use this for initialization
	void Start () {
		distance = this.transform.position - ball.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LateUpdate()
	{
		this.transform.position = ball.transform.position + distance;
	}
}

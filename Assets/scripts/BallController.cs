using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallController : MonoBehaviour {

	public Text scoreText;
	public Text winText;
	public float speed;
	private Rigidbody rb;
	private int score;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//called every time the physics update
	void FixedUpdate()
	{
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		Vector3 v3 = new Vector3 (horizontal, 0.0f, vertical);

		rb.AddForce (v3 * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Collectable")) 
		{
			other.gameObject.SetActive (false);
			score++;
			scoreText.text = "Score: " + score.ToString();

			if (score >= 8) 
			{
				winText.text = "You Win!!!";
			}
		}
	}
}

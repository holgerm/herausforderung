using UnityEngine;
using System.Collections;

public class greg : MonoBehaviour
{

	Rigidbody2D body;
	public bool gucktNachRechts = false;
	public float speed;
	public float sprung;
	Animator animator;
	public GameObject kugelPrefab;
	GameObject spawnpoint;

	// Use this for initialization
	void Start ()
	{
		body = GetComponent<Rigidbody2D> ();
		animator = GameObject.Find ("Körper teile").GetComponent<Animator> ();
		spawnpoint = GameObject.Find ("spawn point");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("Fire1")) {
			animator.SetTrigger ("Schießen");
		}
	}

	void FixedUpdate ()
	{
		float bewegung = Input.GetAxis ("Horizontal");
		animator.SetFloat ("Speed", Mathf.Abs (bewegung));

		body.velocity = new Vector2 (bewegung * speed, body.velocity.y);

		if ((bewegung > 0 && !gucktNachRechts) || (bewegung < 0 && gucktNachRechts)) {
		  	
			umdrehen ();
		}


		sprung = Input.GetAxis ("Vertical");
		
		if (sprung > 0.5) { 
			body.velocity = new Vector2 (body.velocity.x, body.velocity.y + (speed / 5));
		}

	}

	public void umdrehen ()
	{ 
		gucktNachRechts = !gucktNachRechts;
		Vector3 myscale = transform.localScale;
		myscale.x = - myscale.x;
		transform.localScale = myscale;
	}

	public void schiess ()
	{
		GameObject kugel = (GameObject)Instantiate (kugelPrefab, spawnpoint.transform.position, Quaternion.identity);
		if (gucktNachRechts) {
			kugel.GetComponent<Rigidbody2D> ().AddForce (Vector3.right * 500);
		} else {
			kugel.GetComponent<Rigidbody2D> ().AddForce (Vector3.left * 500);
		}                  
	}
}

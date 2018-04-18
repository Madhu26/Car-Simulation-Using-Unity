using UnityEngine;
using System.Collections;

public class carcontroller : MonoBehaviour{
	public float carSpeed;
	Vector3 position;
	public uiManager1 ui;
	public float maxPos = 2.0f;

	void Start()
	{
		
		position=transform.position;

	}

	void Update()
	{
		position.x +=Input.GetAxis("Horizontal")*carSpeed*Time.deltaTime;
		position.x = Mathf.Clamp(position.x, -1.9f, 2.0f);
		transform.position=position;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "police car") {
			Destroy (gameObject);
			ui.gameOverActivation ();
			ui.Pause ();
		}
	}
}
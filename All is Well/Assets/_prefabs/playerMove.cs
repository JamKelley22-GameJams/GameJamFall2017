using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class playerMove : NetworkBehaviour {

	public GameObject player;
	//public GameObject bulletPrefab;
	//public Transform bulletSpawn;
	public float speed = 1;
	public float jumpForce = 5;
	Rigidbody2D rb2d;
	Collider2D c2d;

	float x,y;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		c2d = GetComponent<Collider2D> ();
		x = 0;
		y = 0;
		player.transform.Translate (new Vector3 (x, y, 0));

	}


	public override void OnStartLocalPlayer()
	{
		//GetComponent<MeshRenderer>().material.color = Color.blue;
	}

	// Update is called once per frame
	void Update () {
		if (!isLocalPlayer)
		{
			return;
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			//CmdFire();
			rb2d.AddForce(new Vector2(0,jumpForce),ForceMode2D.Impulse);

		}
		x += Input.GetAxisRaw ("Horizontal") * Time.deltaTime * speed;
		player.transform.Translate (new Vector3 (x, 0, 0));
		x = 0;
	}

	/*
	[Command]
	void CmdFire()
	{
		// Create the Bullet from the Bullet Prefab
		var bullet = (GameObject)Instantiate (
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.up * 6;

		NetworkServer.Spawn(bullet);

		// Destroy the bullet after 2 seconds
		Destroy(bullet, 2.0f);
	}
	*/
}

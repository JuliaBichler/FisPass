using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Schuss : MonoBehaviour {

	public GameObject kugel1;
	public GameObject panzer;
	public GameObject pfeil;



	void Start () {
		kugel1.transform.position = panzer.transform.position;
	}
	void Update () {
		if (Input.GetKeyUp(KeyCode.Space))
		{
			GameObject geschoss = Instantiate (kugel1) as GameObject;
			geschoss.transform.position = new Vector2(panzer.transform.position.x,panzer.transform.position.y);
			Rigidbody2D rb = geschoss.GetComponent<Rigidbody2D> ();
			//rb.velocity = new Vector2 (10, 12);
			rb.velocity = new Vector2 (12,pfeil.transform.rotation.z*18);
		}

		/*if (Input.GetKey(KeyCode.RightShift))
		{
			GameObject schuss = (GameObject)Instantiate (Schuss);*/

			
	}
}

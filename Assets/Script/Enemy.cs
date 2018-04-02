using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	public GameObject bola;
	public int speed;
	private Vector3 posisiAwal; 
	public Vector3 force;
	void Start () {
		bola = Bola.GetInstance().gameObject;
		posisiAwal=transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.x += (bola.transform.position.x - pos.x)  *Time.deltaTime;
		transform.position = pos;
		if(transform.position.z!= posisiAwal.z){
			Vector3 temp = transform.position;
			temp.z=posisiAwal.z;
			transform.position=temp;

		}
	}
	 public void shoot(GameObject bola)
    {
        bola.GetComponent<Rigidbody>().AddForce(force);
    }
}

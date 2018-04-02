using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int speed;
    private Rigidbody rb;
    // Use this for initialization
    public Vector3 force;
    private int power;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity=Vector3.zero;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            if (force.x > 0)
            {
                force.x *= -1;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            if (force.x < 0)
            {
                force.x *= -1;
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {

            transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * speed);
        }
    }
    public void getBall(GameObject bola)
    {
        FixedJoint hub = gameObject.AddComponent<FixedJoint>();
        bola.transform.position = GetComponentInChildren<Transform>().position;
    }
    public void shoot(GameObject bola)
    {
        bola.GetComponent<Rigidbody>().AddForce(force);
    }
}

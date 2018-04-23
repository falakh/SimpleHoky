using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    private static Bola instance_;
    public static Bola GetInstance()
    {
        return instance_;
    }

    // Use this for initialization
    private string puncher;
    private float speed;
    private Rigidbody rb;

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        instance_ = this;

        GetComponent<Rigidbody>().AddForce(0, 0, -1);
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision other)
    {
        other.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));

        if (other.gameObject.GetComponent<Player>() != null)
        {
            other.gameObject.GetComponent<Player>().shoot(gameObject);
            // rb.AddForce(other.gameObject.GetComponent<Player>().force);
        }
        if (other.gameObject.GetComponent<Enemy>() != null)
        {
            other.gameObject.GetComponent<Enemy>().shoot(gameObject);
        }
        if (other.gameObject.GetComponent<Wall>() != null)
        {
            Wall hit = other.gameObject.GetComponent<Wall>();
            hit.bounce(rb);


        }

    }
}

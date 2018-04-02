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
		 if (other.gameObject.GetComponent<GawangPlayer>() != null)
            {
                MatchSystem.playerGetScore();
            }
 		if (other.gameObject.GetComponent<GawangAi>()!= null)
            {
                MatchSystem.aiGetScore();
				Debug.Log("ai");
            }

    }
}

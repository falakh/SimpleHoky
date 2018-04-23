using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSystem : MonoBehaviour
{
    SpeedDetector speed;

    // Use this for initialization
    void Start()
    {
        speed = GetComponentInChildren<SpeedDetector>();
    }


    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        if (speed != null)
        {
            Vector3 kecepatan = other.gameObject.GetComponent<Rigidbody>().velocity;
            if (other.gameObject.transform.position.z != transform.position.z)
            {
                kecepatan.z *= -1;

            }
            if (other.gameObject.transform.position.x != transform.position.x)
            {
                kecepatan.x *= -1;

            }

        }
    }
}

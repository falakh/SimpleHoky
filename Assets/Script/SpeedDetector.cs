using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDetector : MonoBehaviour
{
    private Vector3 speed;
    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Bola>() != null)
            speed = other.GetComponent<Rigidbody>().velocity;
    }
    public Vector3 getSpeed()
    {
        return speed;
    }


}

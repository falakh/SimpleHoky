using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {
	public bool isVertical;
	public SpeedDetector detector;

	public void bounce(Rigidbody other){
			Vector3  temp  = detector.getSpeed();
		if(isVertical){
			temp.x*=-1;			
			other.velocity=temp;
		}else{
			temp.z*=-1;
			other.velocity=temp;
		}

	}
}

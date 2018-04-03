using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GawangAi : MonoBehaviour {
	
void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.GetComponent<Bola>()!=null){
			MatchSystem.aiGetScore();
		}
	}
	
}

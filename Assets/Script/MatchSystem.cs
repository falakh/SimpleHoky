using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MatchSystem : MonoBehaviour
{
    private static int scorePlayer;
    private static int scoreAi;
    public Text playerScoreBoard, aiScoreBoard;
    // Use this for initialization

    public static void playerGetScore()
    {
        scorePlayer++;
        
    }
    public  static void aiGetScore()
    {
        scoreAi++;
		Debug.Log("Score"+scoreAi);
        
    }
	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
		aiScoreBoard.text = scoreAi.ToString();
		playerScoreBoard.text = scorePlayer.ToString();

	}
	
   
}

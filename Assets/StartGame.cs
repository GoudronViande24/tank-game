using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame: MonoBehaviour
{
	public void startGame(int playerCount)
	{
		if (playerCount != 2)
		{
			Debug.Log("Player count is not 2");
		}
		else
		{
			// Load the game scene
			UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
		}
	}
}

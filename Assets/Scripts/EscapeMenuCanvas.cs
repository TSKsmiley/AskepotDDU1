using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeMenuCanvas : MonoBehaviour
{
    
	public void MainMenu()
	{
		SceneManager.LoadScene(0);
	}

	public void quitGame()
	{
		Application.Quit();
	}

}

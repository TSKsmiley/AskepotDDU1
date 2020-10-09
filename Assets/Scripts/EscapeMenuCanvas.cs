using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeMenuCanvas : MonoBehaviour
{
	public Canvas menuEscape;
	public Camera minimapCamera;

	public void MainMenu()
	{
		SceneManager.LoadScene(0);
	}

	public void quitGame()
	{
		Application.Quit();
	}

	public void EscapeMenu()
	{
		menuEscape.enabled = !menuEscape.enabled;
	}

	public void mapEnable()
	{
		minimapCamera.enabled = !minimapCamera.enabled;
	}

}

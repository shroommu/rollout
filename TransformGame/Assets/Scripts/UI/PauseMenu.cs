using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This class pulls up a pause menu when escape 
 * is pressed, and unpauses it when the same button is pressed.*/

public class PauseMenu : MonoBehaviour 
{

	public GameObject pauseMenuUI;

   	public GameObject gameStateManager;
	private Animator gameStateMachine;

	private bool gameRunning;
	private bool pauseCheckRunning;

	void Start()
	{
		gameStateMachine = gameStateManager.GetComponent<Animator>();
	}

	public void QuitToStart()
	{
		pauseMenuUI.SetActive(false);
		gameRunning = false;
	}

	// Deactivates pause menu UI and resumes time.
	public void Resume()
	{
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;

		//sets isPaused to false when Resume button on Pause Menu is clicked
		gameStateMachine.SetBool("isPaused", false);
	}

	// Activates pause menu UI and freezes time.
	public void Pause()
	{
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;

		gameStateMachine.SetBool("isPaused", true);
	}
}

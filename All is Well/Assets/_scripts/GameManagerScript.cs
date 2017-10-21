using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour {

	public void loadCredits() {
		SceneManager.LoadScene ("CreditsScene");
	}

	public void startGame() {
		SceneManager.LoadScene ("TitleScene");
	}

	public void loadTitle() {
		SceneManager.LoadScene ("TitleScene");
	}
}

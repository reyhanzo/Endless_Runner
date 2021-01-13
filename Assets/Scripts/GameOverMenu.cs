using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverMenu : MonoBehaviour {

	[SerializeField] private Text text;

	public void Retry() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}

	public void MainMenu() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
	}

	public void SetScore(int score) {
		text.text = "SCORE : " + score;
	}
}
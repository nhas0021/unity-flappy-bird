using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreSound;
    public AudioSource gameOverSound;


    public void addScore()
    {
        scoreSound.Play();
        playerScore += 1;
        scoreText.text = playerScore.ToString();
        
    }

    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {   
        gameOverScreen.SetActive(true);
        gameOverSound.Play();
        Time.timeScale = 0f;
    }

}

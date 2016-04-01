using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    //private Text restartText;
    //private Text gameOverText;

    private bool gameOver;
    private bool win;
    public string load;

	// Use this for initialization
	void Start () {
        //Time.timeScale = 1;
        gameOver = false;
        win = false;
        //restartText = GameObject.Find("Restart").GetComponent<Text>();
        //gameOverText = GameObject.Find("GameOver").GetComponent<Text>();
        //restartText.text = "restart";
        //gameOverText.text = "gameOver";
	}//end start
	
	// Update is called once per frame
	void Update () {
        if (win || gameOver)
        {
            //Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.R))
            {
                //Scene sc = SceneManager.GetActiveScene();
                //SceneManager.LoadScene(sc.name);
                SceneManager.LoadScene(load);
            }
        }
	}//end update

    public void GameOver()
    {
        //gameOverText.text = "Game Over!";
       // restartText.text = "Press 'R' for Restart";
        gameOver = true;
    }

    public void playerWin()
    {
        //gameOverText.text = "You won!";
        //restartText.text = "Press 'R' for Restart";
        win = true;
    }

    public bool isGameOver()
    {
        return gameOver;
    }

    public bool isPlayerWin()
    {
        return win;
    }

}

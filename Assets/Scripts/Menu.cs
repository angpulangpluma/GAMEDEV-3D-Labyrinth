using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public string game = "labyrinth";

    public void Game()
    {

        SceneManager.LoadScene(game);

    }

    public void Home()
    {
        SceneManager.LoadScene("HomeMenu");

    }

    public void quit()
    {
        Application.Quit();

    }
}

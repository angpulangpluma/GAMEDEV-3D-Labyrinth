using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DummyHoleCollider : MonoBehaviour {

    private GameController gameController;

	// Use this for initialization
	void Start () {
        GameObject gameControllerObject = GameObject
            .FindGameObjectWithTag("GameController");
        if (gameControllerObject != null)
            gameController = gameControllerObject.GetComponent<GameController>();
        if (gameController == null)
            Debug.Log("Cannot find 'GameController' script");
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colliding!");
        if (other.tag == "Player")
        {
            Debug.Log("Game Over pls");
            other.GetComponent<Rigidbody>().useGravity = true;
            gameController.GameOver();
            SceneManager.LoadScene("GAMOVA2");
            //Destroy(other.gameObject);
        }
    }


	
}

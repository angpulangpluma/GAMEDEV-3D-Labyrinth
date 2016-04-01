using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinHoleCollider : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.name == "Player")
        {

            SceneManager.LoadScene("GAMOVA");

        }

    } 
}

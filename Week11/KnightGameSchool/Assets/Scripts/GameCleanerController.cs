using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCleanerController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other2D)
    {
        if (other2D.tag == "Player")
        {
            other2D.GetComponent<PlayerHealth>().MakeDead();
        }
        else
        {
            Destroy(other2D.gameObject);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void StopGame()
    {
        print("Quitting");
        Application.Quit();
    }
}

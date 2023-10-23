using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    [SerializeField] private bool isReached;

    [SerializeField] GameObject gameWinPanel;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player 1"))
        {
            Debug.Log("Win");

            isReached = true;
        }

        if (other.gameObject.CompareTag("Player 2") && isReached)
        {
            Time.timeScale = 0f;
            gameWinPanel.SetActive(true);
        }
    }
}

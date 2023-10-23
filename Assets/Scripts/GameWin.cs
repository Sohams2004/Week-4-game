
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameWin : MonoBehaviour
{
    [SerializeField] private bool isReached;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player 1"))
        {
            Debug.Log("Win");

            isReached = true;
        }

        if(other.gameObject.CompareTag("Player 2") && isReached)
        {

            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.buildIndex + 1);

            isReached = false;
        }
    }
}

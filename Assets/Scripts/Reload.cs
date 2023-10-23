
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.gameObject.CompareTag("Player 1"))
        {
            GameReload();
        }

        if(other.collider.gameObject.CompareTag("Player 2"))
        {
            GameReload();
        }
    }

    public void GameReload()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }
}

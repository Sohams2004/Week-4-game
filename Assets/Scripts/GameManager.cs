
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameWinPanel;
    [SerializeField] private GameObject pauseScreen;

    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void GameWin()
    {
        Time.timeScale = 0f;
        gameWinPanel.SetActive(true);
    }

    public void GameReload()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }

    public void GamePause()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            pauseScreen.SetActive(true);
        }        
    }

    public void GameResume()
    {
        Time.timeScale = 1f;
    }

    private void Update()
    {
        GamePause();
    }
}

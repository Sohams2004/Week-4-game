
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameWinPanel;

    
    public void GameWin()
    {
        Time.timeScale = 0f;
        gameWinPanel.SetActive(true);
    }

    

    private void Update()
    {
       
    }
}

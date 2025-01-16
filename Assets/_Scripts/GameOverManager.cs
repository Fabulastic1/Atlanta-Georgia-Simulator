using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverCanvas;  
    public GameObject player;          

    private void Start()
    {
       
        gameOverCanvas.SetActive(false);

       
        if (player == null)
        {
            Debug.LogWarning("Player GameObject is not assigned in the inspector!");
        }
    }

    void Update()
    {
        
        if (player == null)
        {
            gameOverCanvas.SetActive(true);
        }
    }

   
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void Continue()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void EndGame()
    {
        Application.Quit();
    }
    
}

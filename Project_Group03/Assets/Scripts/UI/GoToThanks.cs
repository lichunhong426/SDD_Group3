using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToThanks : MonoBehaviour
{
    public void GoToThanksScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Thanks");
    }
}

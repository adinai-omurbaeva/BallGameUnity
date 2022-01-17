using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMainMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1f;
            PlayerCounter.numberCount = 2;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
    void ExitGame()
    {
        PlayerCounter.numberCount = 2;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

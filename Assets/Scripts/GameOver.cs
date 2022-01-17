using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverMenuUI;
    void Update()
    {
        if (PlayerCounter.numberCount == 0)
        {
            gameOverMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}

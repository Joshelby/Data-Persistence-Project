using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartMenu : MonoBehaviour
{
    public TextMeshProUGUI nameInput;
    public TextMeshProUGUI bestScore;

    private void Start()
    {
        UpdateBestScore();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void UpdatePlayerName()
    {
        GameManager.instance.currentPlayerName = nameInput.text;
    }

    void UpdateBestScore()
    {
        bestScore.text = "Best Score : " + GameManager.instance.bestPlayerName + " : " + GameManager.instance.bestPlayerScore;
    }
}

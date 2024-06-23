using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject _gameOverCanvas;
    [SerializeField] private GameObject _scoreText;
    [SerializeField] private GameObject _bestText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }

        Time.timeScale = 1f;

    }

    // Start is called before the first frame update
    public void GameOver()
    {
        _gameOverCanvas.SetActive(true);
        _scoreText.SetActive(false);
        _bestText.SetActive(false);
        Time.timeScale = 0f;

    }

    // Update is called once per frame
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}

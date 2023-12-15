using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public static GameControl Instance;
    public GameObject gameOverText;
    public TextMeshProUGUI scoreText;
    public bool gameOver = false;
    public float groundScrollSpeed = 1.5f;
    public float skyScrollSpeed = 0.5f;

    private AudioSource audioSource;

    private int score = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (gameOver && Input.GetKeyDown(KeyCode.Space) || gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score: " + score.ToString();
        audioSource.Play();
    }

    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}

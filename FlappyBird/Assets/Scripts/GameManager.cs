using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score;
    public Bird bird;
    public Text textScore;
    public GameObject gameeOver;
    public GameObject playButton;

    private void Awake()
    {
        Application.targetFrameRate = 60;

        play();
    }

    public void play()
    {
        bird.enabled = true;

        score = 0;
        textScore.text = score.ToString();

        gameeOver.SetActive(false);
        playButton.SetActive(false);

        Time.timeScale = 1f;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for(int i=0; i<pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }

    }

    public void pause()
    {
        Time.timeScale = 0f;
        bird.enabled = false;

    }

    public void gameOver()
    {
        gameeOver.SetActive(true);
        gameeOver.GetComponent<AudioSource>().Play();
        playButton.SetActive(true);

        pause();
    }

    public void incScore()
    {
        score++;
        textScore.text = score.ToString();
    }
}

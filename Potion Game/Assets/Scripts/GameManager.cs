using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameObject gameOverPanel;
    public TimerBehaviour timerBehaviour;
    public IntData scoreData;

    private bool isGameOver = false;

    void Start()
    {
        timerBehaviour.onCountdownFinished.AddListener(GameOver);
    }
    

    public void GameOver()
    {
        if (!isGameOver)
        {
            isGameOver = true;
            Debug.Log("GameOver");
        }
    }
}
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TimerBehaviour : MonoBehaviour
{
    public UnityEvent countdownStart, updateText, onCountdownFinished;
    public FloatData countdown;
    public float timeRemaining;
    
    public TMP_Text timerText;

    private int minutes;
    private int seconds;

    private void Update() 
    {
        if(timeRemaining > 0)
        {

            minutes = Mathf.FloorToInt(timeRemaining / 60);
            seconds = Mathf.FloorToInt(timeRemaining % 60);

            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            // Time expired
            timerText.text = "00:00";
        }
    }

    public void StartCountdown()
    {
        timeRemaining = countdown.data;
        StartCoroutine(RunTimer());
    }

    public IEnumerator RunTimer()
        {
            while (timeRemaining > 0)
            {
                
                timeRemaining -= Time.deltaTime;

                if (timeRemaining <= 0)
                {
                    onCountdownFinished.Invoke();
                    yield break;
                }

                yield return null;
            }
        }

    
}
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TimerBehaviour : MonoBehaviour
{
    public UnityEvent countdownStart, updateText, onCountdownFinished;
    public FloatData countdown;
    public float timeRemaining;
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
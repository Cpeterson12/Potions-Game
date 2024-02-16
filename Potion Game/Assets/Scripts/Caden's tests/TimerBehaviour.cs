using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class TimerBehaviour : MonoBehaviour
{
    public UnityEvent countdownStart, onCountdownFinished;
    public FloatData countdown;
    private float timeRemaining;

    public void BeginCountdown()
    {
        timeRemaining = countdown.data;
        StartCoroutine(RunTimer());
    }

    IEnumerator RunTimer()
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

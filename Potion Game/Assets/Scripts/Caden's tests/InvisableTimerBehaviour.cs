using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InvisableTimerBehaviour : MonoBehaviour
{
      public UnityEvent countdownStart, updateText, onCountdownFinished;
       public FloatData countdown;
       public float timeRemaining;

       private int minutes;
       private int seconds;
   
     
   
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

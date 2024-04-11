using UnityEngine;

public class AddPointsBasedTimer : MonoBehaviour
{
    public TimerBehaviour timerBehaviour;
    public IntData score;

    public void AddPoints()
    {
        float remainingTime = timerBehaviour.timeRemaining;
        int pointsToAdd = Mathf.FloorToInt(remainingTime);
        
        score.data += pointsToAdd;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPointsBasedTimer : MonoBehaviour
{
    public FloatData timer;
    public IntData score;
    
    public void AddPoints()
    {
        int pointsToAdd = Mathf.FloorToInt(timer.data);
        score.data += pointsToAdd;
    }
}

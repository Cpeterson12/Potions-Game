using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeatControlBehaviour : MonoBehaviour
{
    public float heatValue = 0; 
    public float maxHeatValue = 30;
    public Image heatImage;
    
    private float decreaseTimer = 0f;
    private float decreaseInterval = 1.5f;


    public void Update()
    {
        
        decreaseTimer += Time.deltaTime;
        if (decreaseTimer >= decreaseInterval)
        {
            decreaseTimer = 0f;
            heatValue = Mathf.Max(heatValue - 1, 0);
        }

        float fillAmount = heatValue / maxHeatValue;

        heatImage.fillAmount = fillAmount;
        
    }

    public void IncreaseHeat()
    {
        heatValue = Mathf.Min(heatValue + 10, maxHeatValue);
    }
    
    
   
}

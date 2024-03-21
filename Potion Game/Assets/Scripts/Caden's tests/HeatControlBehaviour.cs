using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class HeatControlBehaviour : MonoBehaviour
{
    public UnityEvent pumpEvent;
    public float heatValue = 0; 
    public float maxHeatValue = 30;
    public Image heatImage;
    
    private float decreaseTimer = 0f;
    private float decreaseInterval = 1.5f;
    
    public ParticleSystem particleSystem;


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
        UpdateParticleStartSize();
        
    }

    public void IncreaseHeat()
    {
        heatValue = Mathf.Min(heatValue + 10, maxHeatValue);
        UpdateParticleStartSize();
    }
    
    public void CheckHeatLevel()
    {
        string heatLevel;
        if (heatValue >= 1 && heatValue <= 10)
        {
            heatLevel = "low";
        }
        else if (heatValue >= 11 && heatValue <= 20)
        {
            heatLevel = "Med";
        }
        else
        {
            heatLevel = "High";
        }

        Debug.Log("Heat Level: " + heatLevel);
    }
    private void UpdateParticleStartSize()
    {
        ParticleSystem.MainModule mainModule = particleSystem.main;
        float startSize = 4f; // Default start size

        if (heatValue >= 1 && heatValue <= 10)
        {
            startSize = 4f; // Low heat level
        }
        else if (heatValue >= 11 && heatValue <= 20)
        {
            startSize = 6f; // Medium heat level
        }
        else
        {
            startSize = 8f; // High heat level
        }

        mainModule.startSizeMultiplier = startSize;
    }
    
    public void OnTriggerEnter(Collider other)
    {
        IncreaseHeat();
        pumpEvent.Invoke();
    }
    
    
   
}
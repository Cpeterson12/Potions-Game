using System.Collections;
using UnityEngine;

public class GrowingObject : MonoBehaviour
{
    public float growthAmount = 0.01f;
    public float maxGrowthDuration = 10.0f;
    public float maxGrowthHeight = 2.0f; 

    private Vector3 initialPosition;
    private bool isGrowing = true;
    private bool isRunning = false;
    private float growthTimer = 0.0f;

    public void StartGrowing()
    {
        initialPosition = transform.position;
        StartCoroutine(GrowShrinkCoroutine());
    }

    private IEnumerator GrowShrinkCoroutine()
    {
        isRunning = true;

        // Move the game object upwards
        while (isGrowing && transform.position.y - initialPosition.y < maxGrowthHeight)
        {
            transform.Translate(Vector3.up * growthAmount);
            yield return null;
        }
        isGrowing = false; // Stop upward movement

        // Wait at the raised position
        growthTimer = 0.0f;
        while (growthTimer < maxGrowthDuration)
        {
            growthTimer += Time.deltaTime;
            yield return null;
        }

        // Move the game object back down
        while (transform.position != initialPosition)
        {
            transform.Translate(Vector3.down * growthAmount);
            yield return null;
        }

        isRunning = false;
    }

    public void OnDisable()
    {
        isRunning = false;
    }
}
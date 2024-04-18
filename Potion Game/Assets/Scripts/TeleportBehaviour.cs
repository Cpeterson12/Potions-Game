using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBehaviour : MonoBehaviour
{
    public Vector3Data vectorData;
    public Vector3Data rotationData;

    public void TeleportToVector()
    {
        // Get the Vector3 value from the ScriptableObject
        Vector3 targetPosition = vectorData.value;

        // Teleport the game object to the target position
        transform.position = targetPosition;
        
        Vector3 targetRotation = rotationData.value;
        transform.rotation = Quaternion.Euler(targetRotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBehaviour : MonoBehaviour
{
    public Vector3Data vectorData;

    public void TeleportToVector()
    {
        // Get the Vector3 value from the ScriptableObject
        Vector3 targetPosition = vectorData.value;

        // Teleport the game object to the target position
        transform.position = targetPosition;
    }
}

using UnityEngine;

public class TrashCan : MonoBehaviour 
{

    void OnTriggerEnter(Collider other) 
    {
        Destroy(other.gameObject);
    }

}


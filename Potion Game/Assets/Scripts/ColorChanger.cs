using UnityEngine;
using UnityEngine.Events;

public class ColorChanger : MonoBehaviour
{
    public UnityEvent onRed, onYellow, onBlue;
    
    private IDBehavior idBehavior;
    
    public ID currentIngredientID, redID, yellowID, blueID;
    
    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Blue"))
        {
            currentIngredientID = blueID;
            onBlue.Invoke();
        }
        else if (other.CompareTag("Red"))
        {
            currentIngredientID = redID;
            onRed.Invoke();
        }
        else if (other.CompareTag("Yellow"))
        {
            currentIngredientID = yellowID;
            onYellow.Invoke();
        }
    }
}

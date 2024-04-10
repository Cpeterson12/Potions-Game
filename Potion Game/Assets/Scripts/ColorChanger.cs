using UnityEngine;
using UnityEngine.Events;

public class ColorChanger : MonoBehaviour
{
    public UnityEvent onRed, onYellow, onBlue, onReset;
    
    private IDBehavior idBehavior;
    
    public ID currentIngredientID, redID, yellowID, blueID, defaultID;
    
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
        else if (other.CompareTag("Cauldron") || other.CompareTag("Trash") || other.CompareTag("IngredientBase"))
        {
            Invoke("ResetColor", 1f);
        }
    }
    
    public void ResetColor()
    {
        currentIngredientID = defaultID;
        onReset.Invoke();
    }
}

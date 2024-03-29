using UnityEngine;

public class IDBehavior : MonoBehaviour
{
    public static IDBehavior instance;
    public ID idObj;
    
    private ColorChanger colorChanger;
    
    public void UpdateID()
    {
        idObj = colorChanger.currentIngredientID;
    }
}


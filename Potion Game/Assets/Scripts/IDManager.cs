
using UnityEngine;

public class IDManager : MonoBehaviour
{
    public IDList idList;
    public ID idData;
    public static IDManager instance;
    public ColorChanger colorChanger;

    public void AddIDToList()
    {
        ID newIDData = idData;
        idList.list.Add(newIDData);
    }

    public void ClearIDList()
    {
        idList.list.Clear();
    }
    
    public void UpdateIDColor()
    {
        idData = colorChanger.currentIngredientID;
    }
}

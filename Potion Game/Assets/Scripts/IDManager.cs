
using UnityEngine;

public class IDManager : MonoBehaviour
{
    public IDList idList;
    public ID idData;

    public void AddIDToList()
    {
        ID newIDData = idData;
        idList.list.Add(newIDData);
    }

    public void ClearIDList()
    {
        idList.list.Clear();
    }
}

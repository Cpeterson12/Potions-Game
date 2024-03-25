using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDListCompareBehaviour : MonoBehaviour
{
    public IDList list1;
    public IDList list2;

    public void StartCheck()
    {
        CompareLists(list1, list2);
    }

    public void CompareLists(IDList list1, IDList list2)
    {
        // Check if the lists have the same length
        if (list1.list.Count != list2.list.Count)
        {
            ListsNotEqual();
            return;
        }

       
        Dictionary<ID, int> idCountDict = new Dictionary<ID, int>();

        
        foreach (ID id in list1.list)
        {
            if (idCountDict.ContainsKey(id))
            {
                idCountDict[id]++;
            }
            else
            {
                idCountDict[id] = 1;
            }
        }

        // Check if list2 contains the same IDs as list1
        foreach (ID id in list2.list)
        {
            if (!idCountDict.ContainsKey(id) || idCountDict[id] == 0)
            {
                ListsNotEqual();
                return;
            }
            else
            {
                idCountDict[id]--;
            }
        }

        // If we reach this point, the lists are equal
        ListsEqual();
    }

    private void ListsEqual()
    {
        Debug.Log("The lists are equal!");
       
    }

    private void ListsNotEqual()
    {
        Debug.Log("The lists are not equal!");
        
    }
}

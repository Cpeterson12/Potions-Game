using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDListBehaviour : MonoBehaviour
{
   public IDList listObj;
   public List<IDList> idListsToChooseFrom = new List<IDList>();
   
   public void SelectRandomIDList()
   {
      if (idListsToChooseFrom.Count > 0)
      {
         int randomIndex = Random.Range(0, idListsToChooseFrom.Count);
         listObj = idListsToChooseFrom[randomIndex];
      }
      else
      {
         Debug.LogWarning("No IDLists found in the list! Please add some IDLists to the list.");
      }
   }

   public IDList GetSelectedIDList()
   {
      return listObj;
   }
   
   
}

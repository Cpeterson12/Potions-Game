using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class IDListBehaviour : MonoBehaviour
{
   public IDList listObj;
   public List<IDList> idListsToChooseFrom = new List<IDList>();
   
   public TMP_Text idTextbox;

   public void Awake()
   {
      UpdateIDTextbox();
   }

   public void SelectRandomIDList()
   {
      if (idListsToChooseFrom.Count > 0)
      {
         int randomIndex = Random.Range(0, idListsToChooseFrom.Count);
         listObj = idListsToChooseFrom[randomIndex];
         UpdateIDTextbox();
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
   
   private void UpdateIDTextbox()
   {
      if (listObj != null && listObj.list.Count > 0)
      {
         List<string> idNames = new List<string>();
         foreach (ID id in listObj.list)
         {
            idNames.Add(id.name);
         }
         string idText = string.Join(", ", idNames);
         idTextbox.text = idText;
      }
      else
      {
         idTextbox.text = "No IDs found.";
      }
   }

   
   
}

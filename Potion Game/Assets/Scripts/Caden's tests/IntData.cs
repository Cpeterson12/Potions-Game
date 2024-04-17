using System;
using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int data;

    public void SetValue(int num)
    {
        data = num;
    }
    
    public void SetValue(IntData obj)
    {
        data = obj.data;
    }
  
    public void UpdateValue(int num)
    {
        data += num;
    }

}

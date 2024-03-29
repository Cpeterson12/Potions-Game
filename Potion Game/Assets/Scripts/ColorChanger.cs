using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Material currentMaterial;
    public Material defaultMaterial;
    public Material redMaterial;
    public Material yellowMaterial;
    public Material blueMaterial;
    
    public static ColorChanger instance;
    
    private IDBehavior idBehavior;
    
    public ID currentIngredientID;
    public ID redID;
    public ID yellowID;
    public ID blueID;
  
    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Blue"))
        {
            currentIngredientID = blueID;
            ChangeColor(blueMaterial);
            IDBehavior.instance.UpdateID();
            currentMaterial = blueMaterial;
        }
        else if (other.CompareTag("Red"))
        {
            currentIngredientID = redID;
            ChangeColor(redMaterial);
            IDBehavior.instance.UpdateID();
            currentMaterial = redMaterial;
        }
        else if (other.CompareTag("Yellow"))
        {
            currentIngredientID = yellowID;
            ChangeColor(yellowMaterial);
            IDBehavior.instance.UpdateID();
            currentMaterial = yellowMaterial;
        }
    }
    
    public void ChangeColor(Material material)
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material = material;
        }
    }
}

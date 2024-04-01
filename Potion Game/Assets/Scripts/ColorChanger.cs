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
    public GameObject childIngredient;

    public int matElement;
  
    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Blue"))
        {
            currentIngredientID = blueID;
            ChangeColor(blueMaterial);
            IDBehavior.instance.UpdateID();
            currentMaterial = blueMaterial;
            childIngredient.GetComponent<MeshRenderer>().materials[matElement] = currentMaterial;
        }
        else if (other.CompareTag("Red"))
        {
            currentIngredientID = redID;
            ChangeColor(redMaterial);
            IDBehavior.instance.UpdateID();
            currentMaterial = redMaterial;
            childIngredient.GetComponent<MeshRenderer>().materials[matElement] = currentMaterial;
        }
        else if (other.CompareTag("Yellow"))
        {
            currentIngredientID = yellowID;
            ChangeColor(yellowMaterial);
            IDBehavior.instance.UpdateID();
            currentMaterial = yellowMaterial;
            childIngredient.GetComponent<MeshRenderer>().materials[matElement] = currentMaterial;
        }
    }
    
    public void ChangeColor(Material material)
    {
        currentMaterial = material;
    }
}

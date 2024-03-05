using UnityEngine;

public class IngredientBehaviour : MonoBehaviour
{
    [SerializeField]
    private IngredientSO ingredientData;

    [SerializeField]
    private GameObject visualRepresentation;
    
    public event System.Action<Color> ColorChanged;
    
    void Start()
    {
        if (ingredientData == null)
        {
            Debug.LogError("IngredientData is not assigned for " + gameObject.name);
        }
        else
        {
            SetColor(ingredientData.originalColor);
        }
    }
    
    public void ChangeColor(Color newColor)
    {
        SetColor(newColor);
        ColorChanged?.Invoke(newColor);
    }

    private void SetColor(Color color)
    {
        if (visualRepresentation != null)
        {
            Renderer renderer = visualRepresentation.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = color;
            }
        }
    }
}
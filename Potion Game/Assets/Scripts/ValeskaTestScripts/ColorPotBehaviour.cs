using UnityEngine;

public class ColorPotBehaviour : MonoBehaviour
{
    [SerializeField]
    private Color newColor;

    [SerializeField]
    private GameObject visualRepresentation;

    // Event to notify when an ingredient is dipped
    public event System.Action<IngredientBehaviour> IngredientDipped;

    void OnTriggerEnter(Collider other)
    {
        IngredientBehaviour ingredient = other.GetComponent<IngredientBehaviour>();

        if (ingredient != null)
        {
            DipIngredient(ingredient);
        }
    }

    private void DipIngredient(IngredientBehaviour ingredient)
    {
        // Change the color of the ingredient and notify subscribers
        ingredient.ChangeColor(newColor);
        IngredientDipped?.Invoke(ingredient);
    }
}
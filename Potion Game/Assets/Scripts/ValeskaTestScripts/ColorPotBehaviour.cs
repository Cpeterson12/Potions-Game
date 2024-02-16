using UnityEngine;

public class ColorPotBehaviour : MonoBehaviour
{
    public Color newColor;

    public void ChangeIngredientColor(IngredientSO ingredient)
    {
        // Change the color of the ingredient to the new color
        ingredient.originalColor = newColor;
    }
}
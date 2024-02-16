using UnityEngine;

[CreateAssetMenu(fileName = "New Ingredient", menuName = "Ingredients")]
public class IngredientSO : ScriptableObject
{
    public string ingredientName;
    public Color originalColor;
}
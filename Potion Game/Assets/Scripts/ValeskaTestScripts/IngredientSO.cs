using UnityEngine;

[CreateAssetMenu(fileName = "New Ingredient", menuName = "Ingredients")]
public class IngredientSO : ScriptableObject
{
    public string ingredientName;
    public Color originalColor;
    public event System.Action<Color> ColorChanged;

    public void ChangeColor(Color newColor)
    {
        originalColor = newColor;
        ColorChanged?.Invoke(newColor);
    }
}
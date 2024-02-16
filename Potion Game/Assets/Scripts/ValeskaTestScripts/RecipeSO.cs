using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Recipe List", menuName = "Recipes/Recipe List")]
public class RecipeList : ScriptableObject
{
    public List<Recipe> recipes;
}

[System.Serializable]
public class Recipe
{
    public List<IngredientRequirement> ingredientRequirements;
}

[System.Serializable]
public class IngredientRequirement
{
    public IngredientSO ingredient;
    public Color requiredColor;
}
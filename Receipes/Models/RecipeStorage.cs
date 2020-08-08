using System;
using System.Collections.Generic;
/// <summary>
/// This class stores recipes. this is temporary until database is added.
/// </summary>
namespace Receipes.Models
{
    public static class RecipeStorage
    {
        private static List<Recipe> recipes = new List<Recipe>();

        public static List<Recipe> GetReceipes()
        {
            return recipes;
        }

        public static void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }
    }
}

using Plaints.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plaints.DataAccess
{
    internal class RecipeRepository : IRecipeRepository
    {
        private readonly List<Recipe> _recipes;
        private const string recipeName = "recipe.txt";

        public RecipeRepository()
        {
            _recipes = new List<Recipe>()
            {
                new Recipe() { Name = "demo1", Type="Lunch", ShortDescription="sarme" },
                new Recipe() { Name = "demo2", Type="Breakfast", ShortDescription="jaja" }
            };
        }

        public List<Recipe> GetRecipeByCategory(string category)
        {
            return _recipes.Where(r=> r.Type==category).ToList();
        }

        public Recipe GetRecipeByName(string name)
        {
            return _recipes.Where(r => r.Name.Equals(recipeName)).ToList()[0];
        }

        public List<Recipe> GetRecipeByType(string type)
        {
            return _recipes.Where(r => r.Type.Equals(type)).ToList();
        }
    }
}

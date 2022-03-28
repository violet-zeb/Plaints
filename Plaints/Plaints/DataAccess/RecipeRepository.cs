using Plaints.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plaints.DataAccess
{
    internal class RecipeRepository : IRecipeRepository
    {
        public List<Recipe> GetRecipeByCategory(string category)
        {
            return new List<Recipe>();
        }
    }
}

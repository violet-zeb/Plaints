using Plaints.Models;
using System.Collections.Generic;

namespace Plaints.DataAccess
{
    internal interface IRecipeRepository
    {
        Recipe GetRecipeById(string id);
        
        List <Recipe> GetRecipeByCategory(string category);

        List<Recipe> GetRecipeByType(string type);
    }
}

using Plaints.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plaints.DataAccess
{
    internal interface IRecipeRepository
    {
        List <Recipe> GetRecipeByCategory(string category);

        List<Recipe> GetRecipeByType(string type);

        Recipe GetRecipeByName(string name);
                
    }
}

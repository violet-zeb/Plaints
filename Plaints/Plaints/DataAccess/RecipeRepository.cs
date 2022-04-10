using Plaints.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Plaints.DataAccess
{
    internal class RecipeRepository : IRecipeRepository
    {
        private List<Recipe> _recipes = new List<Recipe>();

        public RecipeRepository()
        {
            LoadRecipesFromJson();
        }

        public Recipe GetRecipeById(string id)
        {
            return _recipes.SingleOrDefault(r => r.Id == id);
        }

        public List<Recipe> GetRecipeByCategory(string category)
        {
            return _recipes.Where(r=> r.Type==category).ToList();
        }

        public List<Recipe> GetRecipeByType(string type)
        {
            return _recipes.Where(r => r.Type.Equals(type)).ToList();
        }
        
        private void LoadRecipesFromJson()
        {
            var stream = typeof(RecipeRepository).Assembly.GetManifestResourceStream("Plaints.Resources.recipe.json");
            using (var reader = new StreamReader(stream))
            {
                var content = reader.ReadToEnd();
                var recipes = JsonConvert.DeserializeObject<RecipeList>(content);
                _recipes = new List<Recipe>(recipes.Recipe);
            }
        }
    }
}

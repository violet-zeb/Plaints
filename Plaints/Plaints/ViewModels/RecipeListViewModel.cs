using Plaints.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Plaints.ViewModels
{
    internal class RecipeListViewModel : BaseViewModel
    {
        internal void LoadRecipes(string category)
        {
            throw new NotImplementedException();
        }
        private string _title;
        private IRecipeRepository _recipeRepository;
        private ObservableCollection<RecipeItemViewModel> _recipes;
        private RecipeItemViewModel _selectedRecipe;

    }
}

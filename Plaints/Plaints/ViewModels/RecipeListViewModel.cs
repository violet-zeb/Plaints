using Plaints.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Plaints.Services;
using Plaints.ViewModels.Items;
using Xamarin.Forms;

namespace Plaints.ViewModels
{
    internal class RecipeListViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly IRecipeRepository _repository;
        private string _categoryName;
        private RecipeItemViewModel _selectedRecipe;

        public RecipeListViewModel(INavigationService navigationService, IRecipeRepository repository)
        {
            _navigationService = navigationService;
            _repository = repository;

            SelectedRecipeChangedCommand = new Command(OnSelectedRecipeChangedCommand);
        }

        public ObservableCollection<RecipeItemViewModel> Recipe { get; set; }

        public string CategoryName
        {
            get => _categoryName;
            set
            {
                _categoryName = value;
                OnPropertyChanged(nameof(CategoryName));
            }
        }

        public RecipeItemViewModel SelectedRecipe
        {
            get => _selectedRecipe;
            set
            {
                _selectedRecipe = value;
                OnPropertyChanged(nameof(SelectedRecipe));
            }
        }

        public ICommand SelectedRecipeChangedCommand { get; }

        internal void LoadRecipes(string category)
        {
            var items = new List<RecipeItemViewModel>();
            var recipes = _repository.GetRecipeByCategory(category);
            foreach (var recipe in recipes)
            {
                items.Add(new RecipeItemViewModel(recipe));
            }

            CategoryName = category;
            Recipe = new ObservableCollection<RecipeItemViewModel>(items);
        }
        
        private void OnSelectedRecipeChangedCommand()
        {
            if (SelectedRecipe == null)
            {
                return;
            }
            
            _navigationService.NavigateToRecipeDetails(SelectedRecipe.RecipeId);
            SelectedRecipe = null;
        }
    }
}

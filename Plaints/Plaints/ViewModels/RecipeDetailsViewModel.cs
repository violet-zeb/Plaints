using Plaints.DataAccess;
using Plaints.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Plaints.ViewModels.Items;
using Xamarin.Forms;

namespace Plaints.ViewModels
{
    internal class RecipeDetailsViewModel : BaseViewModel
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly INavigationService _navigationService;
        
        private string _name;
        private string _backgroundImage;
        private string _longDescription;
        private ObservableCollection<RecipeStepItemViewModel> _steps;
        private ObservableCollection<IngredientItemViewModel> _ingredients;

        public RecipeDetailsViewModel(IRecipeRepository recipeRepository, INavigationService navigationService)
        {
            _recipeRepository = recipeRepository;
            _navigationService = navigationService;
            
            NavigateBackCommand = new Command(OnNavigateBackCommand);
        }

        public ICommand NavigateBackCommand { get; }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string BackgroundImage
        {
            get => _backgroundImage;
            set
            {
                _backgroundImage = value;
                OnPropertyChanged(nameof(BackgroundImage));
            }
        }

        public string LongDescription
        {
            get => _longDescription; 
            set
            {
                _longDescription = value;
                OnPropertyChanged(nameof(LongDescription));
            }
        }
        
        public ObservableCollection<RecipeStepItemViewModel> Steps
        {
            get => _steps;
            set
            {
                _steps = value;
                OnPropertyChanged(nameof(Steps));
            }
        }
        public ObservableCollection<IngredientItemViewModel> Ingredients
        {
            get => _ingredients;
            set
            {
                _ingredients = value;
                OnPropertyChanged(nameof(Ingredients));
            }
        }

        private void OnNavigateBackCommand(object obj)
        {
            _navigationService.NavigateBack();
        }

        public void LoadRecipe(string recipeId)
        {
            var ingredients = new List<IngredientItemViewModel>();
            var steps = new List<RecipeStepItemViewModel>();
            
            var recipe = _recipeRepository.GetRecipeById(recipeId);
            Name = recipe.Name;
            BackgroundImage = recipe.BackgroundImage;
            LongDescription = recipe.LongDescription;

            foreach (var ingredient in recipe.Ingredients)
            {
                ingredients.Add(new IngredientItemViewModel(ingredient));
            }

            foreach (var recipeStep in recipe.Steps)
            {
                steps.Add(new RecipeStepItemViewModel(recipeStep));
            }

            Ingredients = new ObservableCollection<IngredientItemViewModel>(ingredients);
            Steps = new ObservableCollection<RecipeStepItemViewModel>(steps);
        }
    }
}

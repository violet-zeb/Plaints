using Plaints.Models;

namespace Plaints.ViewModels.Items
{
    internal class IngredientItemViewModel : BaseViewModel
    {
        private string _ingredient;

        public IngredientItemViewModel(Ingredients ingredients)
        {
            if (!string.IsNullOrEmpty(ingredients.Amount))
            {
                Ingredient = ingredients.Amount + " ";
            }
            
            if (!string.IsNullOrEmpty(ingredients.Unit))
            {
                Ingredient += ingredients.Unit + " ";
            }
            
            if (!string.IsNullOrEmpty(ingredients.Name))
            {
                Ingredient += ingredients.Name;
            }
        }

        public string Ingredient
        {
            get => _ingredient;
            set
            {
                _ingredient = value;
                OnPropertyChanged(nameof(Ingredient));
            }
        }
    }
}

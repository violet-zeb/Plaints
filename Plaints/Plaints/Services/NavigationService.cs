using Plaints.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Plaints.Services
{
    internal class NavigationService : INavigationService
    {
        public void NavigateBack()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }

        public void NavigateToRecipeDetails(string recipeId)
        {
            var vm = App.Locator.RecipeDetailsViewModel;
            vm.LoadRecipe(recipeId);
            Application.Current
                .MainPage
                .Navigation
                .PushAsync(new RecipeDetailsView { BindingContext = vm });        }


        public void NavigateToRecipeList(string category)
        {
            var vm = App.Locator.RecipeListViewModel;
            vm.LoadRecipes(category);
            Application.Current
                  .MainPage
                  .Navigation
                  .PushAsync(new RecipeListView { BindingContext = vm });
        }
    }
}

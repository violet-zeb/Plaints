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

        public void NavigateToRecipeDetails()
        {
            
        }

        public void NavigateToRecipeList()
        {
            var vm = App.Locator.RecipeListViewModel;
            Application.Current
                  .MainPage
                  .Navigation
                  .PushAsync(new RecipeListView { BindingContext = vm });
        }
    }
}

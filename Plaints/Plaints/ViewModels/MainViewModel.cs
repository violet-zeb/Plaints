using MvvmHelpers;
using MvvmHelpers.Commands;
using Plaints.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Plaints.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private INavigationService _navigationService;
        public MainViewModel(INavigationService navigationService)
        {
           _navigationService = navigationService;
            NavigateToRecipeListCommand = new Command<string>(OnNavigateToRecipeListCommand);
        }

        private void OnNavigateToRecipeListCommand(string category)
        {
            _navigationService.NavigateToRecipeList(category);
        }

        public ICommand NavigateToRecipeListCommand
        {
            get;
            set;
        }
    }
}

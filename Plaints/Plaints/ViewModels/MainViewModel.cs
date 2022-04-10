using Plaints.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace Plaints.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
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

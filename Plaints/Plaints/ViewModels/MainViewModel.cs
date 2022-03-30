using MvvmHelpers;
using Plaints.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plaints.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private INavigationService _navigationService;
        public MainViewModel(INavigationService navigationService)
        {
           _navigationService = navigationService;
            
        }
    }
}

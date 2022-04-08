using Microsoft.Extensions.DependencyInjection;
using Plaints.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plaints.Service
{
    internal class ViewModelLocator
    {
        private IServiceProvider _serviceProvider;

        public ViewModelLocator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public MainViewModel MainViewModel => _serviceProvider.GetService<MainViewModel>();

        public RecipeDetailsViewModel RecipeDetailsViewModel => _serviceProvider.GetService<RecipeDetailsViewModel>();

        public RecipeListViewModel RecipeListViewModel => _serviceProvider.GetService<RecipeListViewModel>();

    }
}

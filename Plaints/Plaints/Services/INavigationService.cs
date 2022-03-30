using System;
using System.Collections.Generic;
using System.Text;

namespace Plaints.Services
{
    internal interface INavigationService
    {
        void NavigateToRecipeList(string category);
        void NavigateToRecipeDetails();
        void NavigateBack();

    }
}

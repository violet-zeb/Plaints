using System;
using System.Collections.Generic;
using System.Text;

namespace Plaints.ViewModels
{
    internal class RecipeNameViewModel : BaseViewModel
    {
        private string _image;
        private string name;
       

        public string Image
        {
            get => _image; 
            set
            {
                _image = value;
                OnPropertyChanged(nameof(Image));
            }
        }

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        
    }
}

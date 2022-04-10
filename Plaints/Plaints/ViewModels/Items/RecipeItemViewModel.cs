using Plaints.Models;

namespace Plaints.ViewModels.Items
{
    internal class RecipeItemViewModel : BaseViewModel
    {
        private string _name;
        private string _shortDescription;
        private string _imageName;

        public RecipeItemViewModel(Recipe recipe)
        {
            RecipeId = recipe.Id;
            Name = recipe.Name;
            ShortDescription = recipe.ShortDescription;
            ImageName = recipe.ThumbnailImage;
        }

        public string RecipeId { get; }
        
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string ShortDescription
        {
            get => _shortDescription;
            set
            {
                _shortDescription = value;
                OnPropertyChanged(nameof(ShortDescription));
            }
        }

        public string ImageName
        {
            get => _imageName;
            set
            {
                _imageName = value;
                OnPropertyChanged(nameof(ImageName));
            }
        }
    }
}

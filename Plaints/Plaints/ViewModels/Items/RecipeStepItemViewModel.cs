using Plaints.Models;

namespace Plaints.ViewModels.Items
{
    internal class RecipeStepItemViewModel : BaseViewModel
    {
        private string _image;
        private string _text;

        public RecipeStepItemViewModel(RecipeStep step)
        {
            Image = step.Image;
            Text = step.Text;
        }

        public string Image
        {
            get => _image; 
            set
            {
                _image = value;
                OnPropertyChanged(nameof(Image));
            }
        }

        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged(nameof(Text));
            }
        }
    }
}

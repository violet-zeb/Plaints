using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plaints.ViewModels
{
    public class MainViewModel 
    {
        public IList<ProductViewModel> Products { get; set; }

        public MainViewModel()
        {
            Products = new ObservableRangeCollection<ProductViewModel>()
            {
                new ProductViewModel()
                {
                    Name = "Breakfast",
                    HeroColor = "#96C9F8",
                    ImageUrl = "",
                    Price = 12,
                    IsFeatured = true
                },
                new ProductViewModel()
                {
                    Name = "Lunch",
                    HeroColor = "#FFCA81",
                    ImageUrl = "",
                    Price = 17,
                    IsFeatured = true
                },
                new ProductViewModel()
                {
                    Name = "Snack",
                    HeroColor = "#D69DFB",
                    ImageUrl = "",
                    Price = 19,
                    IsFeatured = false
                },
                new ProductViewModel()
                {
                    Name = "Dinner",
                    HeroColor = "#74D59E",
                    ImageUrl = "",
                    Price = 14,
                    IsFeatured = true
                },
            };
        }
    }
}

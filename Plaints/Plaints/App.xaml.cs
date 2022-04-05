using Plaints.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("Lora-Regular.ttf", Alias = "LoraRegular")]
[assembly: ExportFont("Lora-Medium.ttf", Alias = "LoraMedium")]

namespace Plaints
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

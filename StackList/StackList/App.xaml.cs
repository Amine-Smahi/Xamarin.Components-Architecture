using StackList.Shared;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StackList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            FakeDB.SeedData();
            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#ffffff"),
                BarTextColor = Color.FromHex("#000000")
            };
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

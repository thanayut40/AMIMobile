using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using AMIMobile.Services;

[assembly: ExportFont("Prompt-Bold.ttf", Alias = "Phompt-Bold")]
[assembly: ExportFont("Prompt-Medium.ttf", Alias = "Phompt-Medium")]
[assembly: ExportFont("Prompt-Regular.ttf", Alias = "Phompt-Regular")]
[assembly: ExportFont("Prompt-Light.ttf", Alias = "Phompt-Light")]

namespace AMIMobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#74065F"),

                BarTextColor = Color.White
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


using MyCicle.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCicle
{
    public partial class App : Application
    {
        public static String DbName;
        public static String DbPath;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public App(string dbPath, string dbName)
        {
            InitializeComponent();

            App.DbName = dbName;
            App.DbPath = dbPath;
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

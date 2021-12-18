using Cordea_Anamaria_Lab10.Services;
using Cordea_Anamaria_Lab10.Views;
using System;
using Cordea_Anamaria_Lab10.Data;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cordea_Anamaria_Lab10
{
    public partial class App : Application
    {
        static ShoppingListDatabase database;
        public static ShoppingListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "ShoppingList.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ListEntryPage());
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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

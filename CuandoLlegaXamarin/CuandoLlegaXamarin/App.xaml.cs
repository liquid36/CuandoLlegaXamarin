using CuandoLlegaXamarin.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CuandoLlegaXamarin
{
    public partial class App : Application
    {
        static Database database;
        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database();
                }
                return database;
            }
        }

        public static INavigation FormsNavigation
        {
            get
            {
                var tabController = App.Current.MainPage as TabbedPage;

                if (tabController != null)
                {
                    return tabController.CurrentPage.Navigation;
                }
                else
                {
                    return App.Current.MainPage.Navigation;
                }
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage =  new CuandoLlegaXamarin.MainPage() ;
            MainPage.Title = "Cuando Llega";            
        }



        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

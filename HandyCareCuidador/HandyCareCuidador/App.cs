using HandyCareCuidador.Data;
using HandyCareCuidador.View;
using HandyCareCuidador.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HandyCareCuidador
{
    public class App : Application
    {
        //public static CuidadorManager CuidadorManagement { get; private set; }
        private static ViewModelLocator _locator;
        public static ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }
        public App()
        {
            // The root page of your application
            //CuidadorManagement = new CuidadorManager(new CuidadorRestService());
            MainPage = new NavigationPage(new ListaCuidador());
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

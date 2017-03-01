/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:HandyCareCuidador"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using HandyCareCuidador.Data;
using HandyCareCuidador.Interface;
using Microsoft.Practices.ServiceLocation;

namespace HandyCareCuidador.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<DetailViewModel>();
            SimpleIoc.Default.Register<ICuidadorRestService, CuidadorRestService>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        public DetailViewModel Detail
        {
            get
            {
                return ServiceLocator.Current.GetInstance<DetailViewModel>();
            }
        }
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}
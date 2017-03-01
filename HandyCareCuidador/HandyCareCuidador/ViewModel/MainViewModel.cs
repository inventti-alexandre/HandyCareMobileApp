using GalaSoft.MvvmLight;
using HandyCareCuidador.Data;
using System.Collections.ObjectModel;
using System;
using HandyCareCuidador.Model;
using System.Threading.Tasks;

namespace HandyCareCuidador
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public static ObservableCollection<Cuidador> cuidadores { get; set; }
        CuidadorRestService cuidadorManagement;
        public MainViewModel()
        {
            Task.Run((()=>GetCuidadores()));
        }

        private async Task GetCuidadores()
        {
            cuidadorManagement = CuidadorRestService.DefaultManager;
            cuidadores = new ObservableCollection<Cuidador>(await cuidadorManagement.RefreshDataAsync());
            RaisePropertyChanged(() => cuidadores);
            var agua = cuidadores.Count;
        }
    }
}
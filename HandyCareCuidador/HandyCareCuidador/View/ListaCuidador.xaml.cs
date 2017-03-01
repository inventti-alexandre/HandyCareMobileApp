using HandyCareCuidador.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HandyCareCuidador.View
{
    public partial class ListaCuidador : ContentPage
    {
        //CuidadorRestService cuidadorManagement;
        public ListaCuidador()
        {
            InitializeComponent();
            BindingContext = App.Locator.Main;
        }

    }

}

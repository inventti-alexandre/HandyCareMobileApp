using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HandyCareCuidador.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HandyCareCuidador.ViewModel
{
    public class DetailViewModel:ViewModelBase
    {
        public DetailViewModel()
        {
            ClickMeCallBackAction = () => { };
            ClickMeComand = new RelayCommand(() => ClickMeCallBackAction());
        }

        public Action ClickMeCallBackAction { get; private set; }
        public Cuidador Cuidador { get; set; }
        public ICommand ClickMeComand { get; private set; }
    }
}

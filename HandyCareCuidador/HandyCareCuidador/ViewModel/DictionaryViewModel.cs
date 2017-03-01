using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandyCareCuidador.ViewModel
{
    public class DictionaryViewModel<T> : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<T> _rows;
        public ObservableCollection<T> Rows
        {
            get
            {
                return _rows;
            }
            set
            {
                _rows = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Model"));
            }
        }
    }
}

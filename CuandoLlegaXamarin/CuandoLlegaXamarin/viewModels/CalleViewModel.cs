using CuandoLlegaXamarin.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuandoLlegaXamarin.viewModels
{
    public class CalleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Calle> calles { get; set; }

        public CalleViewModel()
        {
            calles = new ObservableCollection<Calle>(App.Database.GetCalles("ENTRE"));
        }

    }
}

using CuandoLlegaXamarin.Modelos;
using CuandoLlegaXamarin.Interfaces;
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
        public Calle calle { get; set; }

        public CalleViewModel(Calle calle = null, Colectivo colectivo = null)
        {
            int? cc = null;
            if (colectivo != null)
            {
                cc = colectivo.id;
            }

            if (calle == null)
            {
                calles = new ObservableCollection<Calle>(App.Database.GetCalles(cc));
            }
            else
            {
                calles = new ObservableCollection<Calle>(App.Database.GetIntersecciones(cc, calle.id));
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

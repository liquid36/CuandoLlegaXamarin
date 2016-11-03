using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuandoLlegaXamarin.viewModels
{
    class FavoritosViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string MainText { get; set; }

        public FavoritosViewModel ()
        {
            
            MainText = "Favoritos " + App.Database.GetParadas().Count().ToString();
        }
    }
}

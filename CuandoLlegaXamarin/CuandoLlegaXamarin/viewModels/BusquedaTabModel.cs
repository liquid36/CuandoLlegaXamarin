using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CuandoLlegaXamarin.viewModels
{
    
    class BusquedaTabModel : INotifyPropertyChanged
    {
        public string MainText { get; set; }

        public BusquedaTabModel ()
        {
            MainText = "Gato";
            OnPropertyChanged("MainText");
        }



        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = null)
        {
            var changed = PropertyChanged;

            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

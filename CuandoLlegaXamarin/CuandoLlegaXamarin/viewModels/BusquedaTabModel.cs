using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CuandoLlegaXamarin.viewModels
{
    
    class BusquedaTabModel : INotifyPropertyChanged
    {
        public ICommand porCalleCommand { protected set; get; }
        public ICommand porColectivoCommand { protected set; get; } 

        public BusquedaTabModel ()
        { 
            this.porCalleCommand = new Command(() =>
            {
                App.FormsNavigation.PushAsync(new Views.CalleView());
            });

            this.porColectivoCommand = new Command(() =>
            {

            });

        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

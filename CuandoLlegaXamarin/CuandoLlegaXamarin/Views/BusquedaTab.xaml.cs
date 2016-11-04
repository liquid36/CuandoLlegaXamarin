using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CuandoLlegaXamarin.Views
{
    public partial class BusquedaTab : ContentPage, Interfaces.IListClick
    { 
        public BusquedaTab()
        {
            InitializeComponent(); 

            btnCalle.Clicked += BtnCalle_Clicked;
            btnColectivo.Clicked += BtnColectivo_Clicked;

            _colectivo = null;
            _calle = null;
            _inter = null;

        }

        private void BtnColectivo_Clicked(object sender, EventArgs e)
        {
            App.FormsNavigation.PushAsync(new Views.ColectivosView(this));
        }

        private void BtnCalle_Clicked(object sender, EventArgs e)
        {
            App.FormsNavigation.PushAsync(new Views.CalleView(this));
        }

 
        public void onItemClick(object item)
        {            
            var state = item as Modelos.State;
            if (state.calle == null)
            {
                App.FormsNavigation.PushAsync(new Views.CalleView(this, null, state.colectivo));
                return;
            }

            if (state.interseccion != null && state.colectivo != null)
            {
                App.Current.MainPage.DisplayAlert("Item Selected", state.calle.nombre, "Ok");
                return;
            }

            if (state.interseccion == null)
            {
                App.FormsNavigation.PushAsync(new Views.CalleView(this, state.calle, state.colectivo));
                return;
            }

            App.FormsNavigation.PushAsync(new Views.ColectivosView(this, state.calle, state.interseccion));
            
        }
    }
}

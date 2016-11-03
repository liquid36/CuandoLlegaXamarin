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
        }

        private void BtnColectivo_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnCalle_Clicked(object sender, EventArgs e)
        {
            App.FormsNavigation.PushAsync(new Views.CalleView(this));
        }

        public void onItemClick(object item)
        {
            var calle = item as Modelos.Calle;
            App.Current.MainPage.DisplayAlert("Item Selected", calle.nombre, "Ok");
        }
    }
}

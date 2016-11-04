using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using CuandoLlegaXamarin.Interfaces;

namespace CuandoLlegaXamarin.Views
{
    public partial class CalleView : ContentPage
    {
        public viewModels.CalleViewModel model;
        private IListClick interfaz;
        private Modelos.Colectivo bus;
        private Modelos.Calle calle;

        public CalleView(IListClick i = null, Modelos. Calle calle = null, Modelos.Colectivo bus = null)
        {
            InitializeComponent();
            model = new viewModels.CalleViewModel(calle, bus);
            BindingContext = model;
            this.interfaz = i;
            this.calle = calle;
            this.bus = bus;
            listView.ItemSelected += listView_ItemSelected;               
        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var calle = e.SelectedItem as Modelos.Calle;
            if (calle != null)
            {
                Modelos.State state = new Modelos.State();
                state.colectivo = bus;
                if (this.calle != null)
                {
                    state.calle = this.calle;
                    state.interseccion = calle;
                } else
                {
                    state.calle = calle;
                }
                interfaz.onItemClick(state);
            }

            listView.SelectedItem = null;
        }
    }
}

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
        public CalleView(IListClick i = null)
        {
            InitializeComponent();
            model = new viewModels.CalleViewModel();
            BindingContext = model;
            interfaz = i;

            listView.ItemSelected += listView_ItemSelected;
               
        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var calle = e.SelectedItem as Modelos.Calle;
            if (calle == null)
                return;
            if (interfaz != null)
            {
                interfaz.onItemClick(calle);
            }

            listView.SelectedItem = null;
        }
    }
}

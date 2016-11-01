using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CuandoLlegaXamarin.Views
{
    public partial class BusquedaTab : ContentPage
    {
        private viewModels.BusquedaTabModel model;
        public BusquedaTab()
        {
            InitializeComponent();
            model = new viewModels.BusquedaTabModel();
            BindingContext = model;
            Title = "Cuando Llega";
        }
    }
}

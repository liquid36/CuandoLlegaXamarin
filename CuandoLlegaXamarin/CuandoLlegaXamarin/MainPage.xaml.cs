using CuandoLlegaXamarin.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CuandoLlegaXamarin
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            var tab1 = new NavigationPage(new Views.BusquedaTab());
            tab1.Title = "BUSQUEDA";

            var tab2 = new NavigationPage(new Views.FavoritosView());
            tab2.Title = "FAVORITOS";

            Children.Add(tab1);
            Children.Add(tab2); 

        }
    }
}

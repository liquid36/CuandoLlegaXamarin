using CuandoLlegaXamarin.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CuandoLlegaXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();            
            IEnumerable<Colectivo> list = App.Database.GetItems();

            myLabel.Text = list.ToArray()[5].nombre;

        }
    }
}

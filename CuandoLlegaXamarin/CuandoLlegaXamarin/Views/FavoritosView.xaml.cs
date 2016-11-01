using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CuandoLlegaXamarin.Views
{
    public partial class FavoritosView : ContentPage
    {
        private viewModels.FavoritosViewModel model;
        public FavoritosView()
        {
            InitializeComponent();
            model = new viewModels.FavoritosViewModel();
            BindingContext = model;
            Title = "Favoritos";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CuandoLlegaXamarin.Views
{
    public partial class CalleView : ContentPage
    {
        public viewModels.CalleViewModel model;
        public CalleView()
        {
            InitializeComponent();
            model = new viewModels.CalleViewModel();
            BindingContext = model;
            Title = "Calles";            
        }
    }
}

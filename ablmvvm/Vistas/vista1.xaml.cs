using ablmvvm.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ablmvvm.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vista1 : ContentPage
    {
        public vista1()
        {
            InitializeComponent();
            BindingContext = new VMvista1(Navigation);
        }
    }
}
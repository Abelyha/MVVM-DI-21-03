using ablmvvm.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ablmvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new vista1();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

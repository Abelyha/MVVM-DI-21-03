using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ablmvvm.VistaModelo
{
    public class VMvista1:BaseViewModel
    {
        #region VARIABLES
        string _lblmensaje;
        #endregion
        #region CONSTRUCTOR
        public VMvista1(INavigation navigation)
        {
            Navigation = navigation;
        }

        public VMvista1()
        {
        }
        #endregion
        #region OBJETOS
        public string Lblmensaje
        {
            get { return _lblmensaje; }
            set { SetValue(ref _lblmensaje, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void Cambiarmensaje()
        {
            Lblmensaje = "Holaaaazfaa";
        }
        #endregion
        #region COMANDOS
        public ICommand Cambiarmensajecommand => new Command(Cambiarmensaje);
        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}

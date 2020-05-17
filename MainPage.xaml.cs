using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IngenieriaParcial3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Inicializar();
        }

        private void Inicializar()
        {
            Consulta1.Clicked += Consulta1_Clicked;
            Consulta2.Clicked += Consulta2_Clicked;
            Consulta3.Clicked += Consulta3_Clicked;
        }

        private void Consulta3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MapaAccidentabilidad());
        }

        private void Consulta2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MapaEnCicla());
        }

        private void Consulta1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MapaCicloRutas());
        }
    }
}

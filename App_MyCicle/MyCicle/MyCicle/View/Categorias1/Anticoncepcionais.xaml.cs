using MyCicle.View.Videos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCicle.View.Categorias1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anticoncepcionais : ContentPage
    {
        public Anticoncepcionais()
        {
            InitializeComponent();

            btnEsquemasdetomarpilula.Source = ImageSource.FromResource("MyCicle.Capa.esquemaspilula.jpg");
            btnEmendarpilula.Source = ImageSource.FromResource("MyCicle.Capa.emendarpilula.jpg");
            btnMitospilula.Source = ImageSource.FromResource("MyCicle.Capa.mitospipula.jpg");
            btnTiposediferencasdeanticoncepcionais.Source = ImageSource.FromResource("MyCicle.Capa.tiposediferencas.jpg");
        }

        private async void Btn_Open_EsquemasdeTomarPilula(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new EsquemasdeTomarPilula());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_Open_EmendarPilula(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new EmendarPilula());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

    

        private async void Btn_Open_MitosPilula(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MitosPilula());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }


        private async void Btn_Open_TiposeDiferencasdeAnticoncepcionais(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new TiposeDiferencasdeAnticoncepcionais());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

    }
    
}
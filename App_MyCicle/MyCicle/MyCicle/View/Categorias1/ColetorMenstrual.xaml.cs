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
    public partial class ColetorMenstrual : ContentPage
    {
        public ColetorMenstrual()
        {
            InitializeComponent();

            btnOqueecoletormenstrual.Source = ImageSource.FromResource("MyCicle.Capa.coletormenstrual.jpg");
            btnColetoremvirgens.Source = ImageSource.FromResource("MyCicle.Capa.virgens.jpg");
            btnTamanhodocoletor.Source = ImageSource.FromResource("MyCicle.Capa.tamanhodocoletor.jpg");
            btnLavagemeesterilizacao.Source = ImageSource.FromResource("MyCicle.Capa.lavagem.jpg");
        }


        private async void Btn_Open_OqueeColetorMenstrual(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new OqueeColetorMenstrual());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_Open_ColetoremVirgens(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new ColetoresemVirgens());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

            private async void Btn_Open_TamanhodoColetor(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new TamanhodoColetor());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_Open_LavagemeEsterilizacao(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new LavagemeEsterilizacao());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }


    }
}
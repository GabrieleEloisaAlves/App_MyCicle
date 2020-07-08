using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MyCicle.View.Videos;

namespace MyCicle.View.Categorias1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sangramentos : ContentPage
    {
        public Sangramentos()
        {
            InitializeComponent();

           

             btnPosmenopausa.Source = ImageSource.FromResource("MyCicle.Capa.posmenopausa.jpg");
            btnDiferenca.Source = ImageSource.FromResource("MyCicle.Capa.diferenca.jpg");
            btnCausasesintomas.Source = ImageSource.FromResource("MyCicle.Capa.causasesintomas.jpg");
            btnAposrelacao.Source = ImageSource.FromResource("MyCicle.Capa.aposrelacao.jpg");
        }

        private async void Btn_Open_SangramentoPosMenopausa(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new SangramentoPosMenopausa());
            

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_Open_DiferencaSangramentoeMenstruacao(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new DiferencaSangramentoeMenstruacao());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_Open_CausaseSintomas(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new CausaseSintomas());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private async void Btn_Open_SangramentoAposRelacao(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new SangramentoAposRelacao());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}
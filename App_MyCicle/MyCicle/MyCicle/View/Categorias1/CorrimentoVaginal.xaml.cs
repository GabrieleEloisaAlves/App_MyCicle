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
    public partial class CorrimentoVaginal : ContentPage
    {
        public CorrimentoVaginal()
        {
            InitializeComponent();

            btnCorrimentobrancopastoso.Source = ImageSource.FromResource("MyCicle.Capa.corrimentobranco.jpg");
            btnAcabarcomocorrimento.Source = ImageSource.FromResource("MyCicle.Capa.acabarcomocorrimento.jpg");
            btnCorrimentoamarelo.Source = ImageSource.FromResource("MyCicle.Capa.corrimentoamarelo.jpg");
            btnCoceiraecorrimento.Source = ImageSource.FromResource("MyCicle.Capa.coceiraecorrimento.jpg");
        }

        private async void Btn_Open_CorrimentoBrancoPastoso(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new CorrimentoBranco());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_Open_CorrimentoAmarelo(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new CorrimentoAmarelo());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_Open_AcabarcomoCorrimento(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AcabarcomoCorrimento());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_Open_CoceiraeCorrimento(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new CoceiraeCorrimento());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}
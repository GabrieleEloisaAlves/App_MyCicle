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
    public partial class Ovulacao : ContentPage
    {
        public Ovulacao()
        {
            InitializeComponent();

            btnOvulacao.Source = ImageSource.FromResource("MyCicle.Capa.oqueeovulacao.jpg");
            btnDor.Source = ImageSource.FromResource("MyCicle.Capa.dorovulacao.jpg");
            btnDiadaovulação.Source = ImageSource.FromResource("MyCicle.Capa.diadaovulacao.jpg");
            btnOvulacaotardia.Source = ImageSource.FromResource("MyCicle.Capa.ovulacaotardia.jpg");

        }

        private async void Btn_Open_OqueeOvulacao(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new OqueeOvulacao());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_Open_DornaOvulacao(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new DornaOvulacao());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }



        private async void Btn_Open_DiadaOvulação(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new DiadaOvulação());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_Open_OvulacaoTardia(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new OvulacaoTardia());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}

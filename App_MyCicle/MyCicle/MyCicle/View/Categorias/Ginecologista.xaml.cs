using MyCicle.View.Categorias1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCicle.View.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ginecologista : ContentPage
    {
        public Ginecologista()
        {
            InitializeComponent();

           
        }

        private async void Button_Clicked_Sangramentos(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Sangramentos());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_Ovulacao(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Ovulacao());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_CicloMenstrual(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new CicloMenstrual());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_CorrimentoVaginal(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new CorrimentoVaginal());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_ColetorMenstrual(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new ColetorMenstrual());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_Anticoncepcionais(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Anticoncepcionais());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }

        private void BtVoltar_Clicked(object sender, EventArgs e)
        {
            MasterDetailPage p = (MasterDetailPage)Application.Current.MainPage;
            p.Detail = new NavigationPage(new InicialDetail());
        }
    }
}
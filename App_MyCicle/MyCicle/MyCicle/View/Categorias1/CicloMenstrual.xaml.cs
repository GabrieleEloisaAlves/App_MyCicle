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
    public partial class CicloMenstrual : ContentPage
    {
        public CicloMenstrual()
        {
            InitializeComponent();

            btnInformaçõesdociclo.Source = ImageSource.FromResource("MyCicle.Capa.informacoesdociclo.jpg");
            btnCicloirregular.Source = ImageSource.FromResource("MyCicle.Capa.cicloirregular.jpg");
            btnHormoniosdociclomenstrual.Source = ImageSource.FromResource("MyCicle.Capa.hormoniosdociclomenstrual.jpg");
            btnCiclomenstrualposparto.Source = ImageSource.FromResource("MyCicle.Capa.posparto.jpg");
        }

        private async void Btn_Open_InformacoesdoCiclo(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new InformacoesdoCiclo());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_Open_CicloIrregular(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new CicloIrregular());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_Open_HormoniosdoCicloMenstrual(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new HormoniosdoCicloMenstrual());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Btn_Open_CicloMenstrualposParto(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new CicloMenstrualposParto());


            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}
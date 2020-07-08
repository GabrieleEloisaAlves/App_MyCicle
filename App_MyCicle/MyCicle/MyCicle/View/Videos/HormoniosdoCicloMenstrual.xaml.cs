using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCicle.View.Videos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HormoniosdoCicloMenstrual : ContentPage
    {
        public HormoniosdoCicloMenstrual()
        {
            InitializeComponent();
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' height='300' src='https://www.youtube.com/embed/MIrUj5e8phA' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>";

            visualizador.Source = htmlSource;

            descricao.Text = "HORMÔNIOS DO CICLO MENSTRUAL "
                ;


        }
    }
}
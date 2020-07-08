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
    public partial class CausaseSintomas : ContentPage
    {
        public CausaseSintomas()
        {
            InitializeComponent();

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width = '400' height = '300' src='https://www.youtube.com/embed/Vx3CBloZo3k' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen ></ iframe >";

                       visualizador.Source = htmlSource;

            descricao.Text = "Entenda as causas e os sintomas dos sangramentos que acontecem fora de hora com o ginecologista e especialista em reprodução "
                ;


        }
    }
}
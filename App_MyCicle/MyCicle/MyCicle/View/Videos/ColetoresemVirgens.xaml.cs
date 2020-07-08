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
    public partial class ColetoresemVirgens : ContentPage
    {
        public ColetoresemVirgens()
        {
            InitializeComponent();

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' height='300' src='https://www.youtube.com/embed/s7msul7gZxo' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>"; 

            visualizador.Source = htmlSource;

            descricao.Text = "Video sobre virgens e o uso de coletor menstrual, cremes vaginais e absorventes internos.  "
                ;


        }
    }
}
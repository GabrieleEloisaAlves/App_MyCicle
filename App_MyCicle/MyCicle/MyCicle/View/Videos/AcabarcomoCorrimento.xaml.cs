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
    public partial class AcabarcomoCorrimento : ContentPage
    {
        public AcabarcomoCorrimento()
        {
            InitializeComponent();



            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' 
                              height='300'
                              src='https://www.youtube.com/embed/GsDgp1cOtwI'
                              frameborder ='0'
                              allow ='accelerometer;  encrypted-media; gyroscope; 
                             'picture-in-picture'
                              allowfullscreen 
                          </iframe >";
                      
            visualizador.Source = htmlSource;

            descricao.Text = "Algumas dicas importante sobre o Corrimento Vaginal  " 
                ;


        }
    }
}
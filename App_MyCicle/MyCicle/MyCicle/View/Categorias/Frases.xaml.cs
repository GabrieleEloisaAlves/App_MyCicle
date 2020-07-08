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
    public partial class Frases : ContentPage
    {
        public Frases()
        {
            InitializeComponent();
        }

        private void BtVoltar_Clicked(object sender, EventArgs e)
        {
            MasterDetailPage p = (MasterDetailPage)Application.Current.MainPage;
            p.Detail = new NavigationPage(new InicialDetail());
        }
    }
}
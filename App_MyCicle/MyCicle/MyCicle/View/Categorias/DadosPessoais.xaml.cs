using MyCicle.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCicle.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCicle.View.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DadosPessoais : ContentPage
    {
        public DadosPessoais()
        {
            InitializeComponent();
            AtualizaLista();
        }
        public void AtualizaLista()
        {
            ServicesBDCicle dbDados = new ServicesBDCicle(App.DbPath);
            ListasDados.ItemsSource = dbDados.Listar();
        }

        

        private void ListaDados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Dados dados = (Dados)ListasDados.SelectedItem;
            MasterDetailPage p = (MasterDetailPage)Application.Current.MainPage;
            p.Detail = new NavigationPage(new Configuracoes(dados));
        }

        private void BtVoltar_Clicked(object sender, EventArgs e)
        {
            MasterDetailPage p = (MasterDetailPage)Application.Current.MainPage;
            p.Detail = new NavigationPage(new InicialDetail());
        }
    }
}
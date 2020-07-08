using MyCicle.Model;
using MyCicle.ViewModel;
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
    public partial class Configuracoes : ContentPage
    {
        int id;
        public Configuracoes()
        {
            InitializeComponent();
        }

        public Configuracoes (Dados dados)
        {
            InitializeComponent();

            btSalvar.Text = "Alterar";

            btExcluir.IsVisible = true;

            id = dados.Id;
            txtData.Text = dados.Data;
            txtDataMestrual.Text = dados.DataMestrual;
            txtPilula.Text = dados.Pilula;
            txtConsulta.Text = dados.Consulta;

        }
        private void BtCancelar_Clicked(object sender, EventArgs e)
        {
            MasterDetailPage p = (MasterDetailPage)Application.Current.MainPage;
            p.Detail = new NavigationPage(new InicialDetail());
        }

        private void BtSalvar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Dados dados = new Dados();
                dados.Data = txtData.Text;
                dados.DataMestrual = txtDataMestrual.Text;
                dados.Pilula = txtPilula.Text;
                dados.Consulta = txtConsulta.Text;
                
                ServicesBDCicle dbNotas = new ServicesBDCicle(App.DbPath);
                if (btSalvar.Text == "Inserir")
                {
                    dbNotas.Inserir(dados);
                    DisplayAlert("Resultado da operação", dbNotas.StatusMessage, "OK");
                }
                else
                {
                    dados.Id = id;
                    dbNotas.Alterar(dados);
                    DisplayAlert("Resultado da operação", dbNotas.StatusMessage, "OK");

                }

                Voltar();
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "OK");
            }
        }

        public void Voltar()
        {
            MasterDetailPage p = (MasterDetailPage)Application.Current.MainPage;
            p.Detail = new NavigationPage(new InicialDetail());
        }

        private async void btExcluir_Clicked(object sender, EventArgs e)
        {
            bool resp = await DisplayAlert("Excluir Registro",
               "Deseja excluir os dados atuais?",
               "Sim", "Não");

            if (resp)
            {
                ServicesBDCicle dbDados = new ServicesBDCicle(App.DbPath);
                dbDados.Excluir(id);
                await DisplayAlert("Resultado da operação", dbDados.StatusMessage, "OK");
            }
    }
    }
    }
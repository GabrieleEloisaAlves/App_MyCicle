using MyCicle.Model;
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
    public partial class Dicas : ContentPage
    {
        public Dicas()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Categoria
                {
                    Nome = "Cólicas",

                    Causa = "Cólica menstrual, ou dismenorreia, é uma dor pélvica provocada pela liberação de prostaglandina, substância que faz o útero contrair para eliminar o endométrio (camada interna do útero que cresce para nutrir o embrião), " +
                "em forma de sangramento, durante a menstruação, quando o óvulo não foi fecundado.",

                    Solucao = " Faça acupuntura, método que usa agulhas espetadas em pontos estratégicos do corpo auxilia na liberação de endorfina, o que reduz o incômodo causado pela dor abdominal.",


                };

                await Navigation.PushAsync(new VerCategoria(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                var c = new Categoria
                {
                    Nome = "Dores de Cabeça",

                    Causa = "O estrógeno e progesterona são os principais hormônios que regulam o ciclo menstrual. Esses hormônios permanecem em níveis elevados próximo ao início da menstruação, quando então seus níveis no sangue caem." +
                " É justamente essa oscilação hormonal, devido à diminuição dos níveis de estrógeno no sangue, que causa a enxaqueca ",

                    Solucao = "O tratamento para enxaqueca envolve uso de substâncias naturais com propriedades calmantes e protetoras para o sistema nervoso, como chás de sementes de girassol, camomila com laranja ou fazer compressas de alfazema por exemplo. "
                };
                await Navigation.PushAsync(new VerCategoria(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                var c = new Categoria
                {
                    Nome = "Inchaço Abdominal",

                    Causa = "Cerca de uma semana antes da menstruação a barriga fica mais saliente e o inchaço pode durar, em média, até ao quarto dia do período. Isto acontece porque a progesterona ativa a produção de outra hormona, a aldosterona, que influencia o sistema renal e provoca a retenção de líquidos.",

                    Solucao = " Os especialistas recomendam que reduza o consumo de sódio – a melhor forma de reduzir a retenção de líquidos – e que beba muita água durante o dia. Aposte em bebidas naturais diuréticas."
                };
                await Navigation.PushAsync(new VerCategoria(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                var c = new Categoria
                {
                    Nome = "Náuseas",

                    Causa = "Os enjoos e os vômitos no período menstrual estão relacionados com a variação hormonal que ocorre nesse período." +
                   "No caso dos enjoos durante a menstruação serem recorrentes, recomenda-se consultar um médico ou ginecologista para maiores informações.",

                    Solucao = " Para ameninzar o enjoo no período menstrual, recomenda-se evitar alguns alimentos que potencializam esse mal estar, como café, refrigerantes, chocolate, bebidas alcoólicas,  alimentos ricos em sal e em gorduras saturadas. A mulher deve procurar " +
                    " aumentar o consumo de frutas cítricas (laranja, tangerina, abacaxi, limão) e iogurtes.",
                };
                await Navigation.PushAsync(new VerCategoria(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                var c = new Categoria
                {
                    Nome = "Irritabilidade",

                    Causa = "Está ligada ao pico de produção de estrogênio, hormônio feminino que produz a ovulação. Esta síndrome ocorre por conta do desequilíbrio de hormônios e, de que esta alteração orgânica tem como o principal vilão o estresse.",

                    Solucao = "Faça pelo menos 30 minutos de atividades físicas que ajudam a aliviar a mente, de quatro a seis vezes por semana. Exercícios físicos regulares ajudam a melhorar e saúde e aliviam os sintomas de fadiga e alterações de humor. Yoga e meditação também são excelentes opções de atividade."
                };
                await Navigation.PushAsync(new VerCategoria(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                var c = new Categoria
                {
                    Nome = "Medicamentos para TPM",

                    Causa = "O uso de um remédio para TPM - tensão pré menstrual, atenua os sintomas e deixa a mulher mais calma e tranquila, mas para que ele tenha o efeito esperado, deve ser utilizado conforme a orientação do ginecologista pois estes medicamentos não devem ser usados sem o conhecimento do médico porque possuem efeitos colaterais e contraindicações que devem ser respeitadas.  ",

                    Solucao = "Diserim, Cloridrato de Fluoxetina, Cloridrato de Sertralina, Norestin, Doxal"
                };
                await Navigation.PushAsync(new VerCategoria(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            try
            {
                var c = new Categoria

                {
                    Nome = "Atividades Físicas",

                    Causa = "Ao longo do periodo menstrual, a mulher está sujeito a diversas mudanças hormonais e com isso ocorre" +
                    "dores em algumas regiões do corpo+" +
                    "Quando fazemos exercícios, nosso corpo libera hormônios que podem ter efeito analgésico e aliviar as cólicas menstruais.",


                    Solucao = "Alongamentos, pilates, ioga, corrida, treinamento aeróbico em esteira elétrica"
                };
                await Navigation.PushAsync(new VerCategoria(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private void BtVoltar_Clicked(object sender, EventArgs e)
        {
            MasterDetailPage p = (MasterDetailPage)Application.Current.MainPage;
            p.Detail = new NavigationPage(new InicialDetail());
        }
    }
}
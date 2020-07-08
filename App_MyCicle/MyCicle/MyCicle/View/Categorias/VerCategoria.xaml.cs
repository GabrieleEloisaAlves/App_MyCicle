using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyCicle.Model;
namespace MyCicle.View.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerCategoria : ContentPage
    {
        public VerCategoria(Categoria c)
        {
            InitializeComponent();
            this.BindingContext = c;
        }
    }
}
using Ev3AuthLoginRicardo.modelo;
using Ev3AuthLoginRicardo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ev3AuthLoginRicardo.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public async void OnAddImageButtonClicked(object sender, EventArgs e)
        {
        }
    }
}
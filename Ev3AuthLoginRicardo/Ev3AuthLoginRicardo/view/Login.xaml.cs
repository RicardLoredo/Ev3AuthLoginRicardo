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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void registroButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new view.Registro());
        }

        private async void ingresarButton_Clicked(object sender, EventArgs e)
        {
            if (TxtPassword == null || TxtCorreo == null || string.IsNullOrWhiteSpace(TxtPassword.Text) || string.IsNullOrWhiteSpace(TxtCorreo.Text))
            {
                await DisplayAlert("Oops", "Ingrese todos los datos", "Aceptar");
                return;
            }

            UserAuthentication oUsuario = new UserAuthentication()
            {
                email = TxtCorreo.Text,
                password = TxtPassword.Text,
                returnSecureToken = true
            };

            bool respuesta = await ApiServiceAuthentication.Login(oUsuario);
            if (respuesta)
            {
                Application.Current.MainPage = new NavigationPage(new Inicio());
            }
            else
            {
                await DisplayAlert("Oops", "Usuario no encontrado", "OK");
            }
        }
    }
}
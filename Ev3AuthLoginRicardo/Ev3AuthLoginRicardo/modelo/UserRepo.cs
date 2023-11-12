using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;

namespace Ev3AuthLoginRicardo.modelo
{
    public class Usuario
    {
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
    }
}

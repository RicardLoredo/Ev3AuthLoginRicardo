using Ev3AuthLoginRicardo.modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ev3AuthLoginRicardo
{
    public class AppSettings
    {
        public static string ApiFirebase = "https://ev3authloginricardo-default-rtdb.firebaseio.com/";
        private static string KeyAplication = "AIzaSyAHXnihnxNrcloQwRGuj6XiE3o7hb6zXLo\r\n";

        public static ResponseAuthentication oAuthentication { get; set; }
        private static string ApiUrlGoogleApis = "https://identitytoolkit.googleapis.com/v1/";

        public static string ApiAuthentication(string tipo)
        {
            if (tipo == "LOGIN")
                return ApiUrlGoogleApis + "accounts:signInWithPassword?key=" + KeyAplication;
            else if (tipo == "SIGNIN")
                return ApiUrlGoogleApis + "accounts:signUp?key=" + KeyAplication;
            else
                return "";
        }

    }
}

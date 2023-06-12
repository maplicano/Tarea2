using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public class UserData
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Edad { get; set; }
            public string Correo { get; set; }


        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var userData = new UserData
            {
                Nombre = nombre.Text,
                Apellido = apellido.Text,
                Edad = edad.Text,
                Correo = correo.Text
            };

            Navigation.PushAsync(new Page1
            {
                BindingContext = userData
            });
        }

    }
}

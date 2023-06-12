using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Tarea2.MainPage;

namespace Tarea2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var userData = BindingContext as UserData;

            if (userData != null)
            {
                // Accede a las propiedades del objeto userData
                var nombre = userData.Nombre;
                var apellido = userData.Apellido;
                var edad = userData.Edad;
                var correo = userData.Correo;
                // Haz lo que necesites con los datos ingresados por el usuario
                // ...
            }
        }
    }
}
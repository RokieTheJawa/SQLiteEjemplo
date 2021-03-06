using SQLite;
using SQLiteEjemplo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteEjemplo.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NuevoPage : ContentPage
    {
        public NuevoPage()
        {
            InitializeComponent();
        }

        private void cmdGuardar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                DisplayAlert("Error", "Los campos no deben estar vacíos", "Aceptar");
            }
            else
            {
                Persona persona = (Persona)BindingContext;
                using (var conn = new SQLiteConnection(App.RUTA_DB))
                {
                    conn.CreateTable<Persona>();

                    if (persona.Id != 0)
                    {
                        conn.Update(persona);
                    }
                    else
                    {
                        conn.Insert(new Persona() { Nombre = txtNombre.Text, Correo = txtCorreo.Text, Telefono = Convert.ToInt32(txtTelefono.Text) });
                    }
                }
                Navigation.PopAsync();
            }
        }
        private void cmdCancelar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void cmdEliminar_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Importante", "¿Está seguro que desea eliminar", "Sí", "No"))
            {
                Persona persona = (Persona)BindingContext;
                using (var conn = new SQLiteConnection(App.RUTA_DB))
                {
                    conn.Delete(persona);
                }
                await Navigation.PopAsync();

            }
        }
    }

}

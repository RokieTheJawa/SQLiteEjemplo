﻿using System;
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
                if (App.seleccionado == true)
                {
                    //App.Personas.RemoveAt(App.indice);
                    //App.Personas.Insert(App.indice, new Modelo.Persona() { Nombre = txtNombre.Text, Correo = txtCorreo.Text, Telefono = txtTelefono.Text });
                    App.seleccionado = false;
                    Navigation.PopAsync();
                }
                else
                {
                    //App.Personas.Add(new Modelo.Persona() { Nombre = txtNombre.Text, Correo = txtCorreo.Text, Telefono = txtTelefono.Text });
                    Navigation.PopAsync();
                }
            }
        }

        private void cmdCancelar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
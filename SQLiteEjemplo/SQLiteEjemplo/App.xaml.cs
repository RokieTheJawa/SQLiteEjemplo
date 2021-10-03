using SQLiteEjemplo.Modelo;
using SQLiteEjemplo.Vistas;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteEjemplo
{
    public partial class App : Application
    {
        public static bool seleccionado;

        public static int indice;
        //public static List<Persona> Personas { get; set; }

        public static string RUTA_DB;
        public App(string rutaDB)
        {
            InitializeComponent();

            RUTA_DB = rutaDB;

            //Personas = new List<Persona>();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

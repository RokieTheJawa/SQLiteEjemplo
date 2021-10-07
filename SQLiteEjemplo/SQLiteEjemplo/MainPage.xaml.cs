using SQLite;
using SQLiteEjemplo.Modelo;
using SQLiteEjemplo.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLiteEjemplo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lstPersonas.ItemsSource = null;

            using (var conn = new SQLiteConnection(App.RUTA_DB))
            {
                conn.CreateTable<Persona>();
                lstPersonas.ItemsSource = conn.Table<Persona>().OrderBy(n=>n.Nombre).ToList();
            }

        }

        private void lstPersonas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Persona persona = (Persona)e.SelectedItem;
            Navigation.PushAsync(new NuevoPage() { BindingContext = persona });
        }

        private void tlbNuevo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NuevoPage() { BindingContext=new Persona()});
        }

    }
}

using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteEjemplo.Modelo
{
    public class Persona
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
    }
}

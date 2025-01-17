using SQLite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace App_Notas.BaseDeDatos.Modelos
{
    public class Nota
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public string Color { get; set; }
        public string Categoria { get; set; }
        public string FechaCreacion { get; set; }

        
    }
}

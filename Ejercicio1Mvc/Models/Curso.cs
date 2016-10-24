using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio1Mvc.Models
{
    public class Curso
    {
        

        public int Id { get; set; }
        public string DescCurso { get; set; }
        public double Precio { get; set; }

        //Constructor
        public Curso(int Id, String Descripcion, double Precio)
        {
            this.Id = Id;
            this.DescCurso = Descripcion;
            this.Precio = Precio;
        }
    }
}
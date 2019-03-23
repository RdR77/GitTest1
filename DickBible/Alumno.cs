using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DickBible
{
    public class Alumno
    {
        //propiedades
        public string nombre { get; set; }
        public string apellido { get; set; }

        public int promocion { get; set; }

        //constructores
        public Alumno() { }

        public Alumno(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}

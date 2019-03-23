using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DickBible;


namespace Dicktest
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alud = new Alumno();
            alud.nombre = "Martìn";
            alud.apellido = "Gimenez";

            Alumno alu2 = new Alumno { nombre = "Bruno", apellido = "Lopez" };

            Alumno alu3 = new Alumno("Hernan", "Leguizamon");





            Console.WriteLine("porfilin");
            Console.ReadKey();
        }
    }
}

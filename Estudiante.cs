using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPráctica_LazoRicardo
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Calificacion { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine("Información del estudiante:");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Calificación: " + Calificacion);
        }
    }
}

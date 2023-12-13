using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPráctica_LazoRicardo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Se decidio implementar un menu en donde se encuentre todos los ejercicios solicitadods en la prueba\n");
            Console.WriteLine("Despues de escoger una opción y aparzca el resultado solicitado, se le indica pulsar cualquier teclas para que aparezca el menu\n");
            Console.WriteLine("Una vez presione cualquier tecla repetira el menu\n");

            do
            {
                Console.WriteLine("Ingrese el número del ejercicio que desea ejecutar:");
                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 2");
                Console.WriteLine("3. Ejercicio 3");
                Console.WriteLine("4. Ejercicio 4");
                Console.WriteLine("5. Ejercicio 5");
                Console.WriteLine("6. Salir");
                
                Console.WriteLine("Escoja una opción");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // Ejercicio 1: Variables y Operadores en C#
                        int numero1 = 5;
                        int numero2 = 10;
                        int resultado = numero1 + numero2;
                        Console.WriteLine("El resultado es: " + resultado);
                        break;

                    case 2:
                        // Ejercicio 2: Estructuras de Control en C#
                        Console.WriteLine("Ingrese un nombre:");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese un Edad:");
                        int edad = Convert.ToInt32(Console.ReadLine());

                        if (edad >= 18)
                        {
                            Console.WriteLine(nombre + " es mayor de edad.");
                        }
                        else
                        {
                            Console.WriteLine(nombre + " no es mayor de edad.");
                        }
                        break;

                    case 3:
                    // Ejercicio 3: Programación Orientada a Objetos - Clases y Objetos

                    Estudiante estudiante1 = new Estudiante();
                    estudiante1.Nombre = "Ricardo";
                    estudiante1.Edad = 23;
                    estudiante1.Calificacion = 8.52;

                    Console.WriteLine("Información del estudiante:");
                    Console.WriteLine("Nombre: " + estudiante1.Nombre);
                    Console.WriteLine("Edad: " + estudiante1.Edad);
                    Console.WriteLine("Calificación: " + estudiante1.Calificacion);
                    break;

                    case 4:
                    // Ejercicio 4: Programación Orientada a Objetos - Métodos
                    Estudiante estudiante2 = new Estudiante();
                    estudiante2.Nombre = "André";
                    estudiante2.Edad = 23;
                    estudiante2.Calificacion = 7.0;

                    estudiante2.MostrarInformacion();
                    break;

                    case 5:
                    // Ejercicio 5: Programación Orientada a Objetos - Herencia

                    EstudianteGraduado graduado1 = new EstudianteGraduado();
                    graduado1.Nombre = "Ronald";
                    graduado1.Edad = 22;
                    graduado1.Calificacion = 8.8;
                    graduado1.Titulo = "Ingeniero en Administración de Empresas";

                    graduado1.MostrarInformacion();
                    break;

                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Por favor, ingrese un número válido.");
                        break;
                    }
                 Console.WriteLine("Pulse cualquier tecla para avanzar...");
                 Console.ReadKey();
                 Console.Clear();
            } while (opcion != 6) ;
                }
    }
}

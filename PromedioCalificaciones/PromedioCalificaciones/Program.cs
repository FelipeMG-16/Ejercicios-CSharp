using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioCalificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se asignan las variables en tipo float para usar punto decimal*/
            
            float cantidad, suma, calificacion, promedio;

            Char opcion; /*La opción "si/no" se asigna en variable de tipo char ya que se el valor a ingresar es una letra*/
            
            /*Tanto la suma como la cantidad se inicializan en 0, ya que se irán sumando*/
            suma = 0;
            cantidad = 0;

            do
            {
                Console.WriteLine("Por favor introduce una calificación:" );
                calificacion = float.Parse(Console.ReadLine());
                Console.WriteLine("¿Desea introducir otra calificación? (s para Sí, n para No) :");
                opcion = char.Parse(Console.ReadLine());
                suma = suma + calificacion; 
                cantidad++;
            } while (opcion != 'n'); /*El proceso se termina hasta que la opción introducida es "N"*/

            if (cantidad != 0)
            {
                promedio = suma / cantidad;
                Console.WriteLine("Ingresaste {0} valores y su promedio es {1}", cantidad, promedio);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Muchas gracias por participar");
                Console.WriteLine("");
                Console.WriteLine("¡¡Hasta Pronto!!");
            }
            Console.ReadLine();
        }
    }
}
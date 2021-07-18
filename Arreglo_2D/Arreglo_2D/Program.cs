using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo_2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int fila, column; /* Declaramos las variables para que se asignarlas tanto a las filas como a las columnas */
            Console.Write("Por favor ingresa un valor del 1 al 10 para poder darle tamaño a tu matriz:");
            Console.WriteLine();
            Console.WriteLine();
            
            fila = Convert.ToInt32(Console.ReadLine());
            column = fila;
            Console.WriteLine();
            Console.WriteLine();

            int[,] a = new int[fila, column]; /* Declaramos el arreglo*/

            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    a[i, j] = i + 1 + j;
                }
            }
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("  {0}  ", a[i, j]);  /* Escribrimos los valores del arreglo, para una mayor estética se agregan espacios antes del {0} */
                }
                Console.WriteLine("\n");
                Console.WriteLine();
            }

            Console.WriteLine("¡¡Muchas gracias por participar. Hasta pronto!!");
            Console.ReadKey();
        }
    }
}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace actividad3_SentenciasControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU DE OPCIONES");
            Console.WriteLine("");
            Console.WriteLine("1. Validar Suma");
            Console.WriteLine("2. Salir");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el Numero de su Opcion:");
            int opc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            switch (opc)
            {
                case 1:
                    int sum1, sum2, sum3, a, b, c; //declarando mis variables//
                    Console.WriteLine("Capture numero 1");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Capture numero 2");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Capture numero 3");
                    c = int.Parse(Console.ReadLine());
                    sum1 = a + b; sum2 = b + c; sum3 = a + c; //sumando y asignando
if ((sum1 == sum2) && (sum2 == sum3)) //comparando si la Sum1 es
{
                        Console.WriteLine("SON IGUALES");
                    }
else
                    {
                        Console.WriteLine("SON DISTINTOS");
                    }
                    break;
                case 2:
                    Console.WriteLine("HASTA LUEGO, BY SILVESTRE SANTIAGO CORONADO");
                    break;
                default:
                    Console.WriteLine("Opcion no Valida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
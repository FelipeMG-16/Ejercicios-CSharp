using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenciasDeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3; /* Asignamos los valores de los tres numeros solicitados */
            
            /* Solicitamos al usuario ingrese los valores para cada uno de los números */
            Console.WriteLine("********** BIENVENIDO **********");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Ingresa el primer número:");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo número:");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el tercer número:");
            numero3 = int.Parse(Console.ReadLine());

            /* Aquí creamos el menú para que el usuario elija una opción*/
            Console.WriteLine("");
            Console.WriteLine("******** MENÚ ********");
            Console.WriteLine("");
            Console.WriteLine("1. Validar suma");
            Console.WriteLine("2. Salir");
            Console.WriteLine("");
            Console.WriteLine("Por favor elija una opción:");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch (opcion)
            {
                case 1:
                    if ((numero1 + numero2 == numero3) || (numero2 + numero3 == numero1) || (numero1 + numero3 == numero2)) /* Realizamos las sumas
             haciendo uso operadores de igualdad, de esta forma no hacemos un uso desmedido de la instrucción if, ya que podríamos raelizar las operacione
             por separado e irlas validando una a una comparandolas entre si */
                        Console.WriteLine("Los números son iguales");
                    else
                        Console.WriteLine("Los números son distintos");
                    break;
                case 2:
                    Console.WriteLine("Muchas gracias por participar, hasta pronto");
                    break;
                

                default:
                    Console.WriteLine("Elegiste una opción no válida");
                    break;
            }
            Console.ReadKey();
        }
    }
}



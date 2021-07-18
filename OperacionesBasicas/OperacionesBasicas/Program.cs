using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2; /* Se declaran las variables de punto flotante*/
            double suma, resta, multi, div, residuo; /* Se asignan en las variables de tipo double*/
            Console.WriteLine("Por favor introduce el valor del primer número");
            numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Por favor introduce el valor del segundo número");
            numero2 = float.Parse(Console.ReadLine());
            suma = numero1 + numero2;
            resta = numero1 - numero2;
            multi = numero1 * numero2;
            div = numero1 / numero2;
            residuo = numero1 % numero2; /* El residuo es el resultado que se obtiene al dividir un número entre otros. Por ejemplo, 
                                          * Si se dividen números que comparten el mismo común divisor, el residuo será 0. Si no es así, 
                                          * el residuo será difernte de 0. Para realizar esta operación, se hace uso del operador %,
                                          * utilizándolo en este caso como "numero1 % numero2, que se traduce como el residuo de dividir
                                          * el número 1 entre el número 2*/
            Console.WriteLine("El resultado de sumar {0} + {1} es = {2}", numero1, numero2, suma);
            Console.WriteLine("El resultado de restar {0} - {1} es = {2}", numero1, numero2, resta);
            Console.WriteLine("El resultado de multiplicar {0} * {1} es = {2}", numero1, numero2, multi);
            Console.WriteLine("El resultado de dividir {0} / {1} es = {2}", numero1, numero2, div);
            Console.WriteLine("El residuo de dividir {0} / {1} es = {2}", numero1, numero2, residuo);
            Console.ReadKey();
        }
    }
}

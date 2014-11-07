using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsSumaPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, numero3, numero4, suma, promedio;
            Console.WriteLine("SUMA Y PROMEDIO DE 4 NUMEROS");

            Console.WriteLine("Ingrese numero 1: ");
            numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2: ");
            numero2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 3: ");
            numero3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 4: ");
            numero4 = float.Parse(Console.ReadLine());

            suma = numero1 + numero2 + numero3 + numero4;
            Console.WriteLine("La suma de los 4 numeros es: "+suma);
            promedio = (numero1 + numero2 + numero3 + numero4) / 4;
            Console.WriteLine("El promedio de los 4 numeros es: " + promedio);

            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appsentenciaif
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, suma, diferencia, producto, division;
            Console.WriteLine("programa suma diferencia producto y divison de dos numeros");
            Console.WriteLine("digite numero1:");
            num1=double.Parse(Console.ReadLine());
            Console.WriteLine("digite numero2:");
            num2 = double.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                suma = num1 + num2;
                diferencia = num1 - num2;
                Console.WriteLine("la suma es:" + suma);
                Console.WriteLine("la diferencia es:" + diferencia);
            }
            else
            {
                producto = num1 + num2;
                division = num1 - num2;
                Console.WriteLine("el producto es:" + producto);
                Console.WriteLine("la division es:" + division);
            }
                Console.ReadKey();
        }
           
    }
}

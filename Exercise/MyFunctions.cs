using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise
{
    public class MyFunctions
    {

        public static void nNumberInFibonnacci()
        {
            string text;
            int number;
            int a=0;
            int b=1;
            int temp;
            Console.Clear();
            Console.WriteLine("Ingrese el numero: ");
            text=Console.ReadLine();
            while (!int.TryParse(text, out number) || number < 2)
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero valido: ");
                text=Console.ReadLine();
            }
            for (int i = 0; i <= number; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
                if (i+1 == number)
                {
                    Console.Clear();
                    Console.WriteLine($"F{number} = {a}");
                    Console.ReadLine();
                }
            } 
        }
        public static void NumberIntoFibonnacci()
        {
            string text;
            int number;
            int a=0;
            int b=1;
            int temp;
            bool isFibo=false;
            Console.Clear();
            Console.WriteLine("Ingrese el numero: ");
            text=Console.ReadLine();
            while (!int.TryParse(text, out number) || number < 2)
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero valido: ");
                text=Console.ReadLine();
            }
            for (int i = 0; i < number; i++)
            {
                if (number == a)
                    isFibo=true;
                temp = a;
                a = b;
                b = temp + b;
            }
            if (isFibo)
            {
                Console.Clear();
                Console.WriteLine($"{number} es numero de Fibonnacci");
                Console.ReadLine();
            }
            else 
            {
                Console.Clear();
                Console.WriteLine($"{number} no es numero de Fibonnacci");   
                Console.ReadLine();
            }
        }
        public static void SequenceFibonnaci()
        {
            string text;
            int number;
            int a=0;
            int b=1;
            int temp;
            Console.Clear();
            Console.WriteLine("Ingrese el numero: ");
            text=Console.ReadLine();
            while (!int.TryParse(text, out number) || number < 2)
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero valido: ");
                text=Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine($"Los primeros {number} numeros de Fibonnacci son: ");
            for (int i = 0; i < number; i++)
            {
                Console.Write($"{a} ");
                temp = a;
                a = b;
                b = temp + b;
            }
            Console.ReadLine();
        }

    }
}
using ClassLibrary3;
using ConsoleApp1.Foo;
using System;
namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {

            string value;
            int x= 0;
            int y = 0;
            int z = 0;
            int w =  0;
            Func<int, int, int> operacion = Resta;
            Func<int, int, int> operacion2 = Suma;
            Setter(ref x);
            Setter(ref y);
            z = Op(x, y);
            Setter(ref w);
            int last = Op(z, w);
            Console.ReadLine();

        }
        private static void Setter (ref int x)
        {
            string value;
            int result = 0;
            string input;
            Console.WriteLine("Ingrese un numero");
            input = Console.ReadLine();
            if (int.TryParse(input, out int int3))
            {
                x = int.Parse(input);
            }
            else
            {
                x = 0;
            }
        }
        private static int Op(int x, int y)
        {
            string value;
            int result = 0;
            Console.WriteLine("Ingrese S para sumar, R para restar, M para multiplicar, o D para dividir");
            value = Console.ReadLine();
            switch (value.ToLower())
            {
                case "s":
                    result = Suma(x, y);
                    Console.WriteLine("Tu resultado fue {0}", result);
                    break;
                case "r":
                    result = Resta(x, y);
                    Console.WriteLine("Tu resultado fue {0}", result);
                    break;
                case "m":
                    result = Multi(x, y);
                    Console.WriteLine("Tu resultado fue {0}", result);
                    break;
                case "d":
                    if (x == 0 || y == 0)
                    {
                        Console.WriteLine("Estas dividendo por 0! Blasfemia!");
                    }
                    else
                    {
                        result = Divi(x, y);
                        Console.WriteLine("Tu resultado fue {0}", result);
                    }
                    break;
                default:
                    Console.WriteLine("Has ingresado un caracter no valido");
                    result = 0;
                    break;
            }


            return result;
        }
        private static int Suma(int x, int y)
        {
            return x + y;
        }
        private static int Resta(int x, int y)
        {
            return x - y;
        }
        private static int Multi(int x, int y)
        {
            return x * y;
        }
        private static int Divi (int x, int y)
        {
            return x / y;
        }

    }
}
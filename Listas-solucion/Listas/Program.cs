using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 1 mostrar los numeros impares entre 0 y 100.
 */
namespace Listas
{
    class Program
    {
        private static List<int> lista = new List<int>();

        static void Main(string[] args)
        {
            SetList();
            Impares(lista);
            Pares(lista);
            MultiplosDe3(lista);
            MultiploDe2Y3(lista);
            List<int> lista2 = new List<int>();
            IngresarNum(lista2);
            MostrarDesde1();
            ContarMultiplos();
            Console.ReadLine();

        }

        public static void SetList()
        {
            for (int i = 0; i <= 100; i++)
            {
                lista.Add(i);
            }
        }

        public static void Impares(List<int> lista)
        {
            Console.WriteLine("Impares del 1 al 100");
            foreach (int i in lista){
                if(!(i%2 == 0))
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();
        }
        public static void Pares(List<int> lista)
        {
            Console.WriteLine("Pares del 1 al 100");
            foreach (int i in lista)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();
        }
        public static void MultiplosDe3(List<int> lista)
        {
            Console.WriteLine("Multiplos de 3 del 0 al 100");
            foreach(int n in lista)
            {
                if (n%3 == 0)
                {
                    Console.Write(n + " ");
                }
            }
            Console.WriteLine();
        }
        public static void MultiploDe2Y3(List<int> lista)
        {
            Console.WriteLine("Multiplos de 2 y 3 del 0 al 100");
            foreach (int n in lista)
            {
                if (n%2 == 0 || n%3 == 0)
                {
                    Console.Write(n+" ");
                }
            }
            Console.WriteLine();
        }
        public static void IngresarNum(List<int> lista)
        {
            Console.WriteLine("Ingresar un numero y te mostramos la suma de los anteriores");
            int i = 0;
            int final = 0;
            string ingresar;
            do
            {
                Console.WriteLine("Ingrese un numero");
                ingresar = Console.ReadLine();
            } while (!(int.TryParse(ingresar, out i)));

            for (int a = 0; a<=i; a++)
            {
                lista.Add(a);
            }
            foreach (int n in lista)
            {
                final += n;
            }
            Console.WriteLine(final);
            Console.WriteLine();
        }
        public static void MostrarDesde1()
        {
            Console.WriteLine("Ingresar un numero y te mostramos desde el 1 hasta ese numero");
            int i = 0;
            string ingresar;
            do
            {
                Console.WriteLine("Ingrese un numero");
                ingresar = Console.ReadLine();
            } while (!(int.TryParse(ingresar, out i)));
            for (int a = 1; a<=i; a++)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }
        public static void ContarMultiplos()
        {
            Console.WriteLine("Multiplos de 3 desde el numero ingresado");
            int i = 0;
            int count = 0;
            string ingresar;
            do
            {
                Console.WriteLine("Ingrese un numero");
                ingresar = Console.ReadLine();
            } while (!(int.TryParse(ingresar, out i)));
            for (int a = 1; a<= i; a++)
            {
                if (a%3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Hay {0} numeros multiplo de 3 desde el numero ingresado",count);
            Console.WriteLine();
        }
    }
}

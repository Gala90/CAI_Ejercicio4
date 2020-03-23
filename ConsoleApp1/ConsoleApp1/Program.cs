using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string palabra1;
            string palabra2;

            Console.WriteLine("Ingrese una palabra: ");
            palabra1 = Console.ReadLine();

            Console.WriteLine("Ingrese otra palabra: ");
            palabra2 = Console.ReadLine();

            char[] array1 = palabra1.ToCharArray();
            char[] array2 = palabra2.ToCharArray();

            if (array1.Length == array2.Length)
            {

                for (i = 0; i < array1.Length; i++)
                {
                    if (Array.Exists(array2, element => element == array1[i]))
                    {
                        string arr = new string(array2);
                        int index = arr.IndexOf(array1[i]);
                        arr = arr.Remove(index, 1);
                        array2 = arr.ToCharArray();

                    }
                }

                if (array2.Length == 0)
                {
                    Console.WriteLine("Es anagrama");
                }
                else
                {
                    Console.WriteLine("No es anagrama");
                }
            }
            else
            {
                Console.WriteLine("No es anagrama");
            }

            Console.ReadKey();
        }
    }
}

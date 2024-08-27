using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasificacion_de_la_edad_using_if_extended_y_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s";
            while (continuar == "s")
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad < 0)
                {
                    Console.WriteLine("Edad incorrecta.");
                } else if (edad <= 2)
                {
                    Console.WriteLine("Eres un Bebe");
                } else if (edad < 12)
                {
                    Console.WriteLine("Eres un Niño");
                } else if (edad < 18)
                {
                    Console.WriteLine("Eres un Adolecente");
                } else if (edad <= 65)
                {
                    Console.WriteLine("Bienvenido al mundo de las responsabilidades");
                } else if (edad <= 80)
                {
                    Console.WriteLine("Eres un adulto mayor");
                } else 
                {
                    Console.WriteLine("Larga Vida");
                }
                Console.Write("Desea continuar presione s, sino cualquier tecla.");
                continuar = Console.ReadLine();
            }
        }
    }
}

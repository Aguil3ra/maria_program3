using System;
using System.Diagnostics;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("porfavor ingrese su numero");
            // int nota = int.Parse(Console.ReadLine());

            // EvualuarNota(nota);

            rotar2();
            
        }

        static void EvualuarNota(int nota)
        {
            if (nota>50)
            {
                Console.WriteLine("aprobado");
            }
            else
            {
               Console.WriteLine("reprobado"); 
            }
        } 
        static void rotar()
        {
            string numero = Console.ReadLine();
            char ultimo = numero[numero.Length -1];
            string resto =numero.Substring(0, numero.Length -1);
            string resultado = ultimo + resto;
            Console.WriteLine(resultado);
        }

        static void rotar2()
        {
            string numero = Console.ReadLine();
            char primero = numero[0];
            char segundo = numero[1];
            // char ultimo = numero[numero.Length -1];
            string resto =numero.Substring(2, numero.Length -2);
            string resultado = resto + primero + segundo;
            Console.WriteLine(resultado);
        }
    }
}

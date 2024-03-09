using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //int [] numeros ={1,2,3,4,5,6,7,8};
           //imprimirVector(numeros);

            //cambiodedatos();

            int [] cambio ={1,2,3,4,5,6,7,8};
           intercambio(cambio);
        }
        static void intercambio( int[] cambio)
        {
            int temp = cambio[3];
            cambio[3] = cambio[2];
            cambio[2] = temp;
            Console.WriteLine("\n vector con posiciones intercambiadas");
            imprimirVector(cambio);
        }
        static void cambiodedatos()
        {
            int[] numeros = {1,2,3,4,5};
            Console.WriteLine("vector antes");
            imprimirVector(numeros);
 
            numeros[3]=50;
            Console.WriteLine("vector despues");
            imprimirVector(numeros);
        }
        static void imprimirVector(int[] vector)
        {
            string vectorString = "";
            foreach(int elemento in vector)
            {
                vectorString = vectorString + elemento + " ";
            }
            Console.WriteLine(vectorString);
        }
          //vectores de numeros
          //int[] numeros = new int [] {1,2,3,4,5};

          //vectores de letras 
          //char[] letras = new char[] {"a","b","c","d","e"};

          //vectores de palabras
          //string[] = new string [] {"hola", "mundo", "es", "genial"}; 

        }
         //generar un vector vacio
         // int[] vacio =new int[10];
           // Console.WriteLine("\nVector vacio");
           // ImprimirVector(vacio); 
      
    }


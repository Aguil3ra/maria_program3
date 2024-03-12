using System;
namespace Program
{
    class Program
    {
        
        static void Main(string[] args)
        {
           int [] vector = {2,3,26,9,18,27,5,30};
           recorrervector(vector);
        }
        static void recorrervector(int[] vector)
        {
            int nuevoElemento = 10;
	        int posicion = 1;
	        for (int i = cambio.Length  - 1; i > posicion; i--)
	        {
		        cambio[i] = cambio[i - 1];
	        }
	        cambio[posicion] = nuevoElemento;
	        Console.WriteLine("\nVector despues de la insercion:");
	        ImprimirVector(Cambio);
        }
        
        static void contarmultiplo(int[] vector)
        {
            int multiplo=0;
           
            foreach(int elemento in vector)
            {
                if ((elemento % 3 )== 0)
                {
                    multiplo = multiplo + 1 ;
                }
                
            }
            Console.WriteLine("los multiplos de 3 en total son: " + multiplo);
            
        }
        static void sumavector(int[] vector)
        {
            int par=0;
            int impar=0;
            foreach(int elemento in vector)
            {
                if ((elemento % 2 )== 0)
                {
                    par = par + elemento;
                }
                if ((elemento % 2 )== 1)
                {
                    impar = impar + elemento;
                }
            }
            Console.WriteLine("suma de pares " + par + ", suma de impares " + impar);
            
        }
        static void intercambio( int[] cambio)
        {
            int temp = cambio[5];
            cambio[5] = cambio[1];
            cambio[1] = temp;
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
          

        }
         
    }


using System;
using System.Numerics;
namespace Program
{
    class Program
    {
        
        static void Main(string[] args)
        {
           Console.WriteLine("ingrese una oracion cualquiera");
            string oracion = Console.ReadLine(); 
            LlenarVectorPalabra(oracion);
            
        }

        static void LlenarVectorPalabra(string oracion)
        {
            string [] palabras = oracion.Split(' ');

            invertirVector(palabras);
        }

        static void LlenarVectorString(string palabra)
        {
            char[] letras = new char[palabra.Length];

            for (int i = 0; i < palabra.Length; i++)
            {
                letras[i] = palabra[i];
            }
            Console.WriteLine("El vector llenado con las letras de "+ palabra);
            imprimirVectorGeneral(letras);
        }
    

        //vectores de numeros
        static void LlenarVector(int cantidad)
        {
            int [] vector = new int[cantidad];
            int numero = 1;

            for(int i = 0; i < cantidad; i++)
            {
                while(!esPrimo(numero))
                {
                    numero++;
                }
                vector[i] = numero;
                numero++;
            }
            imprimirVectorGeneral(vector);
        }
        static void recorrervector(int[] vector)
        {
            int nuevoElemento = 10;
	        int posicion = 1;
	        for (int i = vector.Length  - 1; i > posicion; i--)
	        {
		        vector[i] = vector[i - 1];
	        }
	        vector[posicion] = nuevoElemento;
	        Console.WriteLine("\nVector despues de la insercion:");
	        imprimirVector(vector);
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
        static bool esPar(int numero)
        {
            if((numero % 2)== 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool esImpar(int numero)
        {
            if((numero % 2)== 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool esPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <=numero; i++)
            {
                if(numero % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
        static void imprimirVectorLetra(char[] vector)
        {
            string vectorString = "";
            foreach(int elemento in vector)
            {
                vectorString = vectorString + elemento + " ";
            }
            Console.WriteLine(vectorString);
    
        }

        static void imprimirVectorGeneral<T>(T[] vector)
        {
            foreach(T elemento in vector)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }

        static T[] invertirVector<T>(T[] vector)
        {
            T[] vectorInvertido = new T[vector.Length];

            for (int i = 0; i < vector.Length; i++)
            {
                vectorInvertido[i] = vector[vector.Length - 1 - i];
            }
            return vectorInvertido;
        }

    }
}         
    


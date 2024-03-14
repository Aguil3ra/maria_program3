using System;
namespace Program
{
    class Funciones

    {
        static void Main(string[] args)
        {
            int[,] mat = LlenarMatrizSerpiente(4, 4);
            ImprimirMatriz (mat);
           
        }

       static void ImprimirMatriz<T>(T[,] matriz)
        {
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write(matriz[fila, columna] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int[,] LlenarMatrizSerpiente(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas]; // Crear una matriz vacía con las dimensiones especificadas

            int valor = 1;
            for (int fila = 0; fila < filas; fila++)
            {
                // Determinar la dirección de llenado de la fila (izquierda a derecha o derecha a izquierda)
                bool derecha = fila % 2 == 0;

                // Llenar la fila en la dirección determinada
                if (derecha)
                {
                    for (int columna = 0; columna < columnas; columna++)
                    {
                        matriz[fila, columna] = valor++;
                    }
                }
                else
                {
                    for (int columna = columnas - 1; columna >= 0; columna--)
                    {
                        matriz[fila, columna] = valor++;
                    }
                }
            }

            return matriz;
        }

        static int[,] LlenarMatrizA(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas]; // Crear una matriz vacía con las dimensiones especificadas
            int contador = 1;

            for (int f =filas - 1; f >=0; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    matriz[f, c] = contador;
                    contador = contador + 1; // Llenar la matriz con números del 1 al número de columnas
                }
            }

            return matriz;
        }

        static int[,] LlenarMatriz(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas]; // Crear una matriz vacía con las dimensiones especificadas
    
            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    matriz[fila, columna] = columna + 1; // Llenar la matriz con números del 1 al número de columnas
                }
            }

            return matriz;
        }

    }
}

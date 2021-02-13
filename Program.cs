using System;

namespace MatrixDeterminant
{
    class Program
    {
        static void Main(string[] args)
        {
        int[,] array = new int [3, 3] { {1, 3, 5}, {2, 4, 6}, {3, 5, 9} };
            int suma ;
            int i, j;

            suma = 0;

            for ( i = 0; i < 3; i++ )
                for ( j = 0; j < 3; j++ )
                    suma = suma + array[i, j];
            Console.WriteLine("inserta numero", suma );

            
            
        }
    }
}

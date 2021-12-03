using System;

namespace Day2
{
    public static class twoD_Array
    {
       public  static void TwoD_Array()
        {
            Console.WriteLine("Implementing multidimensional array in C#");
            int[,] matrix = new int[2,2];
            //following property(Rank returns the dimensions of an array)
            Console.WriteLine("array has a {0} dimensions",matrix.Rank);
            matrix=new int[,] { { 1,1},{ 2,2} };

            //foreach (var items in matrix)
            //{
            //    Console.Write(items);
            //}

            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    var val = matrix[k, l];

                    Console.Write(val+" ");
                }
                Console.WriteLine();
            }

        }
    }
}

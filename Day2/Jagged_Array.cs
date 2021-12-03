using System;

namespace Day2
{ 
   public static  class Jagged_Array
    {
        public static void jagged_Array()
        {
            // Declare the array of two elements.
            int[][] jaggedArr = new int[4][];

            // Initialize the elements.
            jaggedArr[0] = new int[5] { 1, 3, 5, 7, 9 };
            jaggedArr[2] = new int[2] { 34, 23 };
            jaggedArr[3] = new int[] { };
            jaggedArr[1] = new int[4] { 2, 4, 6, 8 };

            // Display the array elements.
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write("{0}",jaggedArr[i][j]+" ");
                }
                System.Console.WriteLine();
            }
            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}

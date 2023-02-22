namespace Q1
{
    using System.Globalization;
    using System.Runtime.InteropServices;
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[,] myArray = new int[4, 2]; // create array: 4 rows, 2 columns
            myArray[0, 0] = 10; //place  the value 10 in row 0, column 0

            int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } }; // 3 row, 2 column array with values

            Print2DArray(myArray);
            Print2DArray(numbers2D);

            Random r = new Random();        
            int num = r.Next(1,5);

            double d = r.NextDouble();


            Console.WriteLine(num);

            Random r2 = new Random(DateTime.Now.Millisecond);

            */
            string word = "rortor";
            bool pal = true;
            int j = word.Length - 1;
           
            for(int i=0;i<word.Length/2;i++)
             
                {
               
                    if (word[i] != word[j])
                    {
                        pal= false;
                    }
                j--;
                }
            if (pal)

                Console.WriteLine( word+ " Is a palindrome");
            else
                Console.WriteLine(word + " Is not a palindrome");

            Console.ReadLine();

        }
        static void Print2DArray(int[,] z)
        {
            for (int i = 0; i < z.GetLength(0); i++)
            {
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    Console.Write($" {z[i, j]} " );
                }
                Console.WriteLine(); 
            }
        }
    }
}
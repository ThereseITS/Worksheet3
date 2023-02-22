using System;
using static System.Console;
namespace q5
{

/*
1)Generate an array of 20 random integers with values in the range zero to nine.
2)Repeat the computation 100 times, for each position in the array,report the number of times that the first occurrence of a 7 in the array has been in that position. 
*/    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] randomNumbers = new int[20];
            int[] sevensCount = new int[20];
            int sevenPosition = -1;

            GenerateRandomArray(randomNumbers,0,9);
            WriteLine($"Seven is in {FindSevenPosition(randomNumbers)} position.");
           

            for (int i=0;i<100;i++)
            {
                GenerateRandomArray(randomNumbers,0,9);
                PrintArray(randomNumbers);
                sevenPosition = FindSevenPosition(randomNumbers); 
                if (sevenPosition !=-1)
                {
                    sevensCount[sevenPosition]++;
                }
            }
            PrintArray(sevensCount);
     
        }
        /// <summary>
        /// Prints an integer array
        /// </summary>
        /// <param name="numbers"></param>
        static void PrintArray(int[] numbers) 
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                WriteLine($" {i} : {numbers[i]}");
            }
        }
        /// <summary>
        /// Generates an array of random numbers from min to max-1
        /// </summary>
        /// <param name="randomNumbers"></param>
        /// <param name="min">smallest number </param>
        /// <param name="max">largest number +1 </param>
        public static void GenerateRandomArray(int[] randomNumbers, int min,int max)
        {
            Random random = new Random();

            if (randomNumbers != null)
            {
                for (int i = 0; i < randomNumbers.Length; i++)
                {
                    randomNumbers[i] = random.Next(min,max);
                }
            }

        }
        public static int FindSevenPosition(int[] numbers)
           {
          int sevenFirstPosition = -1;
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == 7)
                    {
                        sevenFirstPosition = i;
                    }
                }
            }
            return sevenFirstPosition;
        }
    }

}

 
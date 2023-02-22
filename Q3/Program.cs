using System.Reflection.Metadata.Ecma335;
using static System.Console;
namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 56, 22, 99, 67, 89, 23, 44, 12, 78, 1 };
            
            PrintArray(numbers);
            SortAscending(numbers);
            PrintArray(numbers);
        }

/// <summary>
/// Prints an integer array 
/// </summary>
/// <param name="numbers">array to print</param>
 
        static void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Write($"   {numbers[i]}");
            }
            WriteLine();
        }
/// <summary>
/// -sorts an integer array of numbers in ascending order, if the array exists (not null).
/// </summary>
/// <param name="numbers"></param>
        static void SortAscending(int[] numbers)
        {
            if(numbers==null)
            {            
                return;
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                       
                    }

                }
                

            }
        }

        /// <summary>
        /// This method checks if an integer array is sorted in ascending order
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        static bool IsSorted(int[] numbers)
        {
            bool sorted = true;
            for (int i = 0; i < numbers.Length - 1; i++)
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                        sorted = false;
                }

            return sorted;
        }

    }


}
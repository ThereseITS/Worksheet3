using System.Reflection.Metadata.Ecma335;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 56, 22, 99, 67, 89, 23, 44, 12, 78, 1 };
            int[] numbers2 = new int[10];
            numbers[0] = 7;
            Console.WriteLine($"{Min(numbers)}");
        }

        static int Min(int[] numbers)
        {
        
            int smallest = numbers[0];//56 22 12 1
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest= numbers[i];
                    Console.WriteLine($"{smallest} is the smallest");
                }
            }
            return smallest;
        }
        static void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"   {numbers[i]}");
            }
            Console.WriteLine();
        }

        static int Fibonacci(int n)
        {
            int n1 = 0;
            int n2 = 1;
            int sum;

            for (int i = 2; i < n; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
            }

            return n == 0 ? n1 : n2;
        }
        static void Sort(int[] numbers)
        {

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
                    PrintArray(numbers);

                }
                Console.WriteLine($"AfterPass {i+1} :");
                PrintArray(numbers);

            }
        }
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
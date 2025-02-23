namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] counts = new int[5];

            Random r = new Random();

            for (int i = 0; i < 10000; i++)
            {
                // note here that to generate between 0 and 4 we need to put 5 as the limit.         
                int num = r.Next(0, 21);
                Console.WriteLine(num);
                counts[num]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine($"{i}     :    {counts[i]}");
            }       
            
            
        }

    }
}
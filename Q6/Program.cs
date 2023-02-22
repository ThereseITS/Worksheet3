namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] counts = new int[5];
            for (int i = 0; i < 10000; i++)
            {
                Random r = new Random();
                int num = r.Next(0, 5);
                Console.WriteLine(num);
                counts[num]++;
            }
            for(int i=0;i<counts.Length;i++)
            {
                Console.WriteLine($"{i}     :    {counts[i]}");
            }
            
        }
    }
}
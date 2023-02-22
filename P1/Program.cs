namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] players = { "Jane", "Pat", "Tim", "Liliana" };
            int[,] scores = new int[players.Length, 4];
            Console.WriteLine("Hello, World!");
            GetScores(players, scores);
            PrintScores(players,scores);
            Console.WriteLine();
        }

        static void GetScores(string[] players, int[,] z)
        {
            for (int i = 0; i < z.GetLength(0); i++)
            {
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    Console.Write($" Please enter scores for player {players[i]} match {j}: ");
                    z[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }

        static void Print2DArray(int[,] z)
        {
            for (int i = 0; i < z.GetLength(0); i++)
            {
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    Console.Write($" {z[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void PrintScores(string[] players, int[,] z)
        {
            for (int i = 0; i < z.GetLength(0); i++)
            {
                Console.Write(players[i] + " ");
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    Console.Write($" {z[i, j]} ");
                }
                Console.WriteLine();
            }
        }

    }
}
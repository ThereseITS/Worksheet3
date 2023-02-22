// Write a program to read in and store the goals that 5 players scored
// in 4 different matches and print out report with the format below.
// Try and make your code as adaptable as you can 

using System;
using static System.Console;
namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] players = { "Jane", "Pat", "Tim", "Liliana" };
            int[,] scores = new int[players.Length, 4];
           
            GetScores(players, scores);
            PrintScores(players,scores);
            
        }

        static void GetScores(string[] players, int[,] z)
        {
            for (int i = 0; i < z.GetLength(0); i++)
            {
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    Write($" Please enter scores for player {players[i]} match {j}: ");
                    z[i, j] = int.Parse(ReadLine());
                }
                WriteLine();
            }
        }

        static void Print2DArray(int[,] z)
        {
            if (z != null)
            for (int i = 0; i < z.GetLength(0); i++)
            {
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    Write($" {z[i, j]} ");
                }
                WriteLine();
            }
        }
        static void PrintScores(string[] players, int[,] z)
        {
            if ((players!=null) && (z!=null))
            for (int i = 0; i < z.GetLength(0); i++)
            {
                Write(players[i] + " ");
                for (int j = 0; j < z.GetLength(1); j++)
                {
                  Write($" {z[i, j]} ");
                }
                WriteLine();
               
            }
        }

    }
}
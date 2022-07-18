using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Queens
{
    public static class Solver
    {
        private static int Steps = 0;
        public static int[,] Board;
        private static int N = 0;
        static List<int[,]> soultuion = new List<int[,]>();
        
        public static void Go(int n)
        {
            N = n;
            Board = new int[n, n];
            SolveNQueens(0);
            for (int i = 0; i < soultuion.Count; i++)
            {
                PrintSoulutions(soultuion[i]);
            }
            Console.WriteLine("steps taken: " + Steps);
            Console.WriteLine("total soultions: " + soultuion.Count);


        }

        public static void PrintSoulutions(int [,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                string display = "";
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    display += (arr[i, j] == 1) ? "Q" : "-";
                }
                Console.WriteLine(display);
            }
            Console.WriteLine("---------------------------");
        }
        private static void SolveNQueens(int row)
        {

            if (row == N)
            {
                int[,] copy = new int[N, N];
                Array.Copy(Board, copy, Board.Length);
                soultuion.Add(copy);
                return;

            }
            else
            {
                for (int col = 0; col < N; col++)
                {
                    Board[col, row] = 1;
                    Steps++;

                    if (IsSafe(col, row))
                    {
                        SolveNQueens(row + 1);
                    }
                    Board[col, row] = 0;
                }
            }

        }
        private static bool IsSafe(int col,int row)
        {
            if(row != 0)
            {
                //checking above the queen to make sure its safe
                for (int i = row - 1 ; i >= 0; i--)
                {
                    if (Board[col, i]  == 1)
                    {
                        return false;  
                    }
                }

                if(Board[col,row] != Board[0,row])
                {
                    //check the upper left diagnol to make sure is safe
                    for (int i = col -1 , j = row -1; i >= 0 && j >= 0; i--, j--)
                    {
                        if (Board[i, j] == 1)
                        {
                            return false;
                        }
                    }
                }
                

                if(Board[col,row] != Board[N - 1 ,row])
                {
                    //check the upper right diagnol to make sure is safe
                    for (int i = col + 1, j = row - 1; i < N && j >= 0; i++, j--)
                    {
                        if (Board[i, j] == 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;

        }

    }
}

using System;
using X_O;
using static X_O.Logic;
namespace x_o
{
    internal class Print : Logic //mb useless

    {
        private static int[] aTries = new int[3];

    /// <summary>
    /// Method to print the matrix to the console
    /// </summary>
        public static void PrintMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0,3}|{1,3}|{2,3}", Logic.m_avMat3x3[i, 0], Logic.m_avMat3x3[i, 1],
                    Logic.m_avMat3x3[i, 2]);
            }
            Console.WriteLine("\n\tX won {0} times.\n\tO won {1} times.", aTries[0], aTries[1]);
            Console.WriteLine("\tTies: " + aTries[2]);
        }

    /// <summary>
    /// Method to declare the winner and clear the console
    /// </summary>
    /// <param name="winner">The winner of the game</param>
        private static void DeclareWinner(Value winner)
        {
            Console.Clear();
            PrintMatrix();
            Console.WriteLine($"Winner is: {winner}!");
            aTries[(int)winner - 1]++;
            ResetBoard();
        }

    /// <summary>
    /// Method to check the game state
    /// </summary>
        public static void CheckGameState()
        {
            if (Logic.CheckWin(Value.X))
            {
                DeclareWinner(Value.X);
            }
            else if (Logic.CheckWin(Value.O))
            {
                DeclareWinner(Value.O);
            }
            else if (Logic.IsDraw())
            {
                Console.WriteLine("\n\tTie!");
                aTries[2]++;
                ResetBoard();
            }
        }

    /// <summary>
    /// Method to reset the game board
    /// </summary>
        private static void ResetBoard()
        {
            Array.Clear(Logic.m_avMat3x3, 0, Logic.m_avMat3x3.Length);
        }
    }
}
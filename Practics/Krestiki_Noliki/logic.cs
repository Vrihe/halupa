using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using x_o;
using static X_O.Logic;

namespace X_O
{
    internal class Logic
    {
        public enum Value : uint
        {
            X = 1,
            O = 2,
            NON = 0
        }
        public static Value[,] m_avMat3x3 = new Value[3, 3];
        /// <summary>
        /// Update method
        /// </summary>
        public void Update()
        {
            Console.Clear();
            Print.PrintMatrix();
            if (Input())
            {
                AI();
            }
            // Check for win or draw
            Print.CheckGameState();
        }
        /// <summary>
        /// Check if a player has won
        /// </summary>
        /// <param name="player">The player to check for</param>
        /// <returns>True if the player has won, otherwise false</returns>
        public static bool CheckWin(Value player)
        {
            for (int i = 0; i < 3; i++)
            {
                // Check rows and columns
                if ((m_avMat3x3[i, 0] == player && m_avMat3x3[i, 1] == player && m_avMat3x3[i, 2] == player) ||
                    (m_avMat3x3[0, i] == player && m_avMat3x3[1, i] == player && m_avMat3x3[2, i] == player))
                {
                    return true;
                }
            }
            // Check diagonals
            return (m_avMat3x3[0, 0] == player && m_avMat3x3[1, 1] == player && m_avMat3x3[2, 2] == player) ||
                   (m_avMat3x3[0, 2] == player && m_avMat3x3[1, 1] == player && m_avMat3x3[2, 0] == player);
        }
        /// <summary>
        /// Check if the game is a draw
        /// </summary>
        /// <returns>True if the game is a draw, otherwise false</returns>
        public static bool IsDraw()
        {
            foreach (var cell in m_avMat3x3)
            {
                if (cell == Value.NON) return false;
            }
            return true;
        }
        /// <summary>
        /// AI move
        /// </summary>
        private void AI()
        {
            bool bCheck = true;
            int iHorizontal, iVertical;
            Random random = new();
            do
            {
                iHorizontal = random.Next(3);
                iVertical = random.Next(3);
                if (m_avMat3x3[iHorizontal, iVertical] == Value.NON)
                {
                    m_avMat3x3[iHorizontal, iVertical] = Value.O;
                    bCheck = false;
                }
            } while (bCheck);
        }
        /// <summary>
        /// Convert keyboard input to integer
        /// </summary>
        /// <returns>The integer value of the input</returns>
        private int InputToInt()
        {
            int answer = -1;
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    answer = 0; break;
                case ConsoleKey.D2:
                    answer = 1; break;
                case ConsoleKey.D3:
                    answer = 2; break;
                default:
                    Console.WriteLine("\tPick from 1 to 3!");
                    break;
            }
            return answer;
        }
        /// <summary>
        /// Handle player input
        /// </summary>
        /// <returns>True if the input is valid, otherwise false</returns>
        public bool Input()
        {
            int vertical, horizontal;
            while (true)
            {
                Console.WriteLine("\n\tChoose vertical cell (from 1 to 3): ");
                horizontal = InputToInt();
                Console.WriteLine("\n\tChoose horizontal cell (from 1 to 3): ");
                vertical = InputToInt();
                if (vertical != -1 && horizontal != -1)
                {
                    if (m_avMat3x3[horizontal, vertical] == Value.NON)
                    {
                        m_avMat3x3[horizontal, vertical] = Value.X;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("\tThis cell is already claimed, choose another one!");
                    }
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X_O;
using static X_O.logic;

namespace x_o
{
    internal class print
    {
        public static int[] aTries = new int[3];

        //метод выводит матрицу в консоль
        public static void m_print_avMat3x3()
        {
            for (int itr_0 = 0; itr_0 < (3); itr_0++)
            {
                Console.WriteLine("{0,3}|{1,3}|{2,3}", m_avMat3x3[itr_0, 0], m_avMat3x3[itr_0, 1], m_avMat3x3[itr_0, 2]);
            }
            Console.WriteLine("\n\tX won {0} times.\n\tO won {1} times.", print.aTries[0], print.aTries[1]);
            Console.WriteLine("\tTies: " + print.aTries[2]);
        }
        
        //блок выводит победителя на экран, и очищает консоль
        private static void DeclareWinner(Value winner)
        {   logic l = new logic();
            Console.Clear();
             m_print_avMat3x3();
            Console.WriteLine($"Winner is: {winner}!");
            aTries[(int)winner - 1]++;
            ResetBoard();
        }

        //блок отвечающий за статус игры
        public static void CheckGameState()
        {
            if (logic.CheckWin(Value.X))
            {
                DeclareWinner(Value.X);
            }
            else if (logic.CheckWin(Value.O))
            {
                DeclareWinner(Value.O);
            }
            else if (logic.IsDraw())
            {
                Console.WriteLine("\n\tTie!");
                aTries[2]++;
                ResetBoard();
            }
        }

        //очистка консоли
        private static void ResetBoard()
        {
            Array.Clear(m_avMat3x3, 0, m_avMat3x3.Length);
        }
    }

}

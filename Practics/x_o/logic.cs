using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using x_o;
using static X_O.logic;

namespace X_O
{
    internal class logic
    {
        

        public enum Value : uint
        {
            X = 1,
            O = 2,
            NON = 0
        };

        public static Value[,] m_avMat3x3 = new Value[3, 3];

        //метод отрисовки
        public void m_update()
        {
            Console.Clear();
            print.m_print_avMat3x3();

            if (m_Input() == true)
            {
                m_AI();
            }

            // Проверка победы или ничьей
            print.CheckGameState();
        }

        

        public static bool CheckWin(Value player)
        {
            for (int i = 0; i < 3; i++)
            {
                // Проверка строк и столбцов
                if ((m_avMat3x3[i, 0] == player && m_avMat3x3[i, 1] == player && m_avMat3x3[i, 2] == player) ||
                    (m_avMat3x3[0, i] == player && m_avMat3x3[1, i] == player && m_avMat3x3[2, i] == player))
                {
                    return true;
                }
            }
            // Проверка диагоналей
            return (m_avMat3x3[0, 0] == player && m_avMat3x3[1, 1] == player && m_avMat3x3[2, 2] == player) ||
                   (m_avMat3x3[0, 2] == player && m_avMat3x3[1, 1] == player && m_avMat3x3[2, 0] == player);
        }

        //метод отвечает за ничью
        public static bool IsDraw()
        {
            foreach (var cell in m_avMat3x3)
            {
                if (cell == Value.NON) return false;
            }
            return true;
        }

        
        //Ai
        private void m_AI()
        {
            bool bCheck = true;
            int iHorizontal, iVertical;
            Random CRandom = new();
            do
            {
                iHorizontal = CRandom.Next(3);
                iVertical = CRandom.Next(3);
                if (m_avMat3x3[iHorizontal, iVertical] == Value.NON)
                {
                    m_avMat3x3[iHorizontal, iVertical] = Value.O;
                    bCheck = false;
                }
            } while (bCheck);
        }
       
        //метод считывает ввод с клавиатуры
        private int m_iChecToint()
        {
            int iAnswer = -1;
            ConsoleKeyInfo CKey;
            CKey = Console.ReadKey();
            switch (CKey.Key)
            {
                case ConsoleKey.D1:
                    iAnswer = 0; break;
                case ConsoleKey.D2:
                    iAnswer = 1; break;
                case ConsoleKey.D3:
                    iAnswer = 2; break;
                default:
                    Console.WriteLine("\tPick from 1 to 3!");
                    break;
            }
            return iAnswer;
        }
        
        public bool m_Input()
        {
            int ivertical, ihorizontal;
            while (true)
            {
                Console.WriteLine("\n\tChoose vertical cell(from 1 to 3): ");
                ihorizontal = m_iChecToint();
                Console.WriteLine("\n\tChoose horizontal cell(from 1 to 3): ");
                ivertical = m_iChecToint();
                
                //проверка на вшивость

                if (ivertical != -1 && ihorizontal != -1)
                {
                    if (m_avMat3x3[ihorizontal, ivertical] == Value.NON)
                    {
                        m_avMat3x3[ihorizontal, ivertical] = Value.X;
                        return true;
                    }
                    else
                        Console.WriteLine("\tThis cell is already claimed, choose another one!");
                }
            }
        }
    }
}

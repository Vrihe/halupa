using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace x_o_UI
{
    internal class logic
    {

        private static int[,] m_WinConditions = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },//столбцы
                                                  { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },//строки
                                                  { 0, 4, 8 }, { 6, 4, 2 } };//диагональ
        public short m_x_Win_Count;
        public short m_o_Win_Count;
        public short m_Draw;
        public String m_p1 = "X";
        public String m_p2 = "O";
        public bool mm_CheckWin(string Player_Type)
        {
            ////проверка на вшивость игрока
            if ((Player_Type == m_p1 || Player_Type == m_p2) && m_simplecheck(Player_Type))
                return true;
            //sender.GetType().GetProperty("Text").SetValue(sender, "huy");
            return false;

        }
        //step brother stop
        public bool mm_StepPlayer(string Player, object sender)
        {
            //проверка на вшивость игрока(опять)
            if (Player != m_p1 && Player != m_p2)
                return false;
            //проверка на вшивость кнопки
            //if (ButtonNumber < 0 || ButtonNumber > 8)
                //return false;
            //проверка на свободную кассу
            if (sender.GetType().GetProperty("Text").GetValue(sender) != "")
                return false;
            //присвоение значения player (x or o) в кнопку по индексу массива
            sender.GetType().GetProperty("Text").SetValue(sender, Player);
            return true;
        }

        private bool m_simplecheck(string playerType)
        {
            Button[] Buttons = new Button[9]; 
            foreach (Control C in G.FormMain.Controls)
                {if(C is Button)
                {
                Buttons[Convert.ToInt32(C.Tag)] = (Button)C;
                }
            }
            for (int i = 0; i < m_WinConditions.GetLength(0); i++)
            {
                if (Buttons[m_WinConditions[i, 0]].Text == playerType &&
                    Buttons[m_WinConditions[i, 1]].Text == playerType &&
                    Buttons[m_WinConditions[i, 2]].Text == playerType)
                {
                    return true;
                }
            }
                return false;
        }
    }
 }        
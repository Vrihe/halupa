namespace Krestiki_Noliki
{
    internal class Program
    {// матрица но массив
       static int[,] m_aPole = { { 1, 1, 1 }
                        ,{ 1, 1, 1 }
                        ,{ 1, 1, 1 }
                                       };



        static void v_Vivod()
        {
            for (int itr = 0; itr < 3; itr++)
                Console.WriteLine($"{m_aPole[itr, 0]}, {m_aPole[itr, 1]}, {m_aPole[itr, 2]}");


        }

        static void Main(string[] args)
        {
           


            int iVertical,iHorizontal;

            for (; true;)
            {
                v_Vivod();
                

                Console.Write("Введите вертикальный номер ячейки: ");
                iVertical = Convert.ToInt32(Console.ReadLine());
                if (Convert.ToInt32(iVertical) < 0 && Convert.ToInt32(iVertical) > 2)
                {
                    Console.WriteLine("[ERROR]");
                    break;
                }
                Console.Write("Введите горизонтальный номер ячейки: ");
                iHorizontal = Convert.ToInt32(Console.ReadLine());
                if (Convert.ToInt32(iHorizontal) < 0 && Convert.ToInt32(iHorizontal) > 2)
                {
                    Console.WriteLine("[ERROR]");
                    break;
                }
                Console.Write("Введите значение для ячейки: ");
                m_aPole[iVertical, iHorizontal] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Нажмите любую клавишу для след.хода");
                Console.ReadKey();
                Console.Clear();
            }




















            //это главный цикл, он отвечает за всё, itr_0 += 3 отвечает
            //за то чтобы цикл повторился 3 раза, и не обращался к несуществующим 
            //for (int itr_0 = 0; itr_0 < aPole.Length ; itr_0 += 3)
            //{
            //    //этот цикл отвечает за вывод массива на 
            //    for (int itr = 0; itr < aPole.Length / 3; itr++)
            //       //вывод данных матрицы/массива из 1 строки при помощи итерратора
            //        Console.WriteLine($"{aPole[itr, 0]}, {aPole[0 + itr, 1]}, {aPole[0 + itr, 2]}");

            //    //оно отвечает за изменение данных в матрице
            //    //itr_0 это итерратор главного цикла, 
            //    for (int itr = 0; itr < aPole.Length / 3; itr++)
            //        aPole[itr_0 /3,itr] = Convert.ToInt32(Console.ReadLine());


            //}
            //for (int itr = 0; itr < aPole.Length / 3; itr++)

            //    Console.WriteLine($"{aPole[itr, 0]}, {aPole[itr, 1]}, {aPole[itr, 2]}");






            //int iVertical  = Convert.ToInt32(Console.ReadLine()),iHorizontal = Convert.ToInt32(Console.ReadLine());
            //aPole[iVertical, iHorizontal] = Convert.ToInt32(Console.ReadLine());
            //for (int itr = 0; itr < aPole.Length / 3; itr++)
            //    Console.WriteLine($"{aPole[itr, 0]}, {aPole[0 + itr, 1]}, {aPole[0 + itr, 2]}");

        }
    }
}

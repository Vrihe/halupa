namespace X_O
{


    internal class CX_O
    {
        

        public enum value : uint
        {
            X = 1,
            O = 2,
            NON = 0
        };

        public value[,] m_avMat3x3 = { { value.NON, value.NON, value.NON, }
                                    ,  { value.NON, value.NON, value.NON, }
                                    ,  { value.NON, value.NON, value.NON  } };

        /// <summary>
        /// метод обновления
        /// </summary>
        public void m_update()
        {
            m_print_avMat3x3();
            m_Input();
            m_AI();
            if(m_checkW_L (value.X)  == true)
            {
                Console.Clear();
                m_print_avMat3x3();
                Console.WriteLine("Winner is: X!");
                for (int itr_0 = 0; itr_0 < 3; itr_0++)
                {
                    for (int itr_1 = 0;itr_1 < 3; itr_1++)
                    {
                    m_avMat3x3[itr_0,itr_1] = value.NON;
                    }
                }
            }
           else if (m_checkW_L (value.O) == true)
            {
                Console.Clear();
                m_print_avMat3x3();
                Console.WriteLine("Winner is: O!");
                for (int itr_0 = 0; itr_0 < 3; itr_0++)
                {
                    for (int itr_1 = 0; itr_1 < 3; itr_1++)
                    {
                        m_avMat3x3[itr_0, itr_1] = value.NON;
                    }
                }
            }
            else
            {
            Console.Clear();
            }
        }
        /// <summary>
        /// метод проверки на победу
        /// </summary>
        //Функция обращается к массиву и проверяет его значение
        //проверки в цикле отвечают за строки и столбы
        //проверки не в цикле за диагональ
        public bool m_checkW_L(value gamertype)
        {
            bool Win = false;
            for (int itr_0 = 0; itr_0 < 3; itr_0++)
            {
               //это строки
                if (m_avMat3x3[itr_0, 0] == gamertype && m_avMat3x3[itr_0, 1] == gamertype && m_avMat3x3[itr_0, 2] == gamertype)
                {
                    Win = true;
                }
               //это столбы
                if (m_avMat3x3[0, itr_0] == gamertype && m_avMat3x3[1, itr_0] == gamertype && m_avMat3x3[2, itr_0] == gamertype)
                {
                    Win = true;
                }
            }
                                   //первая проверка - диагональ справа на лево  
            if (m_avMat3x3[0, 0] == gamertype && m_avMat3x3[1, 1] == gamertype && m_avMat3x3[2, 2] == gamertype ||
                                           /*вторая - слевана право */
                m_avMat3x3[0,2 ] == gamertype && m_avMat3x3[1, 1] == gamertype && m_avMat3x3[2, 0] == gamertype)
            {
                Win = true;
            }
            return Win;
        }
        /// <summary>
        /// метод отрисовки
        /// </summary>
        public void m_print_avMat3x3()
        {
            for (int itr_0 = 0; itr_0 < (3); itr_0++)
            {             
                    //Console.WriteLine($"{m_avMat3x3[itr_0, 0]} {m_avMat3x3[itr_0, 1]} {m_avMat3x3[itr_0, 2]}");
                    Console.WriteLine("{0,3}|{1,3}|{2,3}", m_avMat3x3[itr_0, 0], m_avMat3x3[itr_0, 1], m_avMat3x3[itr_0, 2]);
            }

        }
        /// <summary>
        /// иишка
        /// </summary>
        public void m_AI()
        {
            bool bCheck = true;
            int iHorizontal, iVertical;
            Random CRandom = new();
            do
            {
                iHorizontal =  CRandom.Next(2);
                  iVertical =  CRandom.Next(2);
                    if (m_avMat3x3[iHorizontal, iVertical] == value.NON)
                    {
                        m_avMat3x3[iHorizontal, iVertical] = value.O;
                        bCheck = false;
                    }
            }while (bCheck);

        
            
        }
       
        //метод считывает ввод с клавиатуры
       public int m_iChecToint()
        {
            ConsoleKeyInfo CKey;
            CKey = Console.ReadKey();
            switch (CKey.Key)
            {
                case ConsoleKey.D1:
                   return 0;
                case ConsoleKey.D2:
                   return 1;
                case ConsoleKey.D3:
                   return 2;
                default:
                    Console.WriteLine("Ты нормально пиши, да?");break;
            }
            return -1;
        }
        //выбирает ячейку и присвает ей Х
        public void m_Input()   
        {
            int ivertical, ihorizontal;
            Console.WriteLine("\n\tВведите вертикальный номер ячейки(от 1 до 3): ");
            ivertical = m_iChecToint();
            Console.WriteLine("\n\tВведите горизонтальный номер ячейки(от 1 до 3): ");
            ihorizontal = m_iChecToint();
            if (m_avMat3x3[ihorizontal, ivertical] == value.NON)
            {
                m_avMat3x3[ihorizontal, ivertical] = value.X;
            }

        }






        //CKey = Console.ReadKey();
        //Console.Clear();
        //switch (CKey.Key)
        //{
        //    case ConsoleKey.Escape:
        //        { 
        //        Console.WriteLine(" huy"); break;
        //       bKey_1 = false;
        //        }
        //    case ConsoleKey.Tab:
        //        Console.WriteLine("zalupa");break;
        //    case ConsoleKey.Enter:
        //        Console.WriteLine("kaskak");break;
        //    case ConsoleKey.W:
        //        Console.WriteLine("pizdq"); break;
        //    default:
        //        Console.WriteLine("Ne ugadal");break;
        //}
    }
}
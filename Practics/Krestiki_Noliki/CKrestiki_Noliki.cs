namespace X_O
{


    internal class CX_O
    {
        public int[] aTries = new int[3];  

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
            Console.Clear();
            m_print_avMat3x3();
            if(m_Input() == true)
            {
            m_AI();
            } 
           //Этот блок отвечает за проверку победы Х-сов
           //он считает количество побед
            if(m_checkW_L (value.X)  == true)
            {
                Console.Clear();
                m_print_avMat3x3();
                Console.WriteLine("Winner is: X!");
                aTries[0]++;
                          //цикл отвечает за обнуление матрицы
                            for (int itr_0 = 0; itr_0 < 3; itr_0++)
                            {
                                for (int itr_1 = 0;itr_1 < 3; itr_1++)
                                {
                                m_avMat3x3[itr_0,itr_1] = value.NON;
                                }
                            }
            }
            //Этот блок отвечает за проверку победы О-ей
            //он считает количество побед
            else if (m_checkW_L (value.O) == true)
            {
                Console.Clear();
                m_print_avMat3x3();
                Console.WriteLine("Winner is: O!");
                aTries[1]++; 
                          //цикл отвечает за обнуление матрицы
                            for (int itr_0 = 0; itr_0 < 3; itr_0++)
                            {
                                for (int itr_1 = 0; itr_1 < 3; itr_1++)
                                {
                                    m_avMat3x3[itr_0, itr_1] = value.NON;
                                }
                            }
            }
           //блок который отвечает за ничью
            else
            {
                int iTmp = 0;
                for (int itr_0 = 0; itr_0 < 3; itr_0++)
                {
                    for (int itr_1 = 0; itr_1 < 3; itr_1++)
                    {
                      if (m_avMat3x3[itr_0,itr_1] != value.NON)
                        {
                            iTmp++;
                         
                        }
                        
                    }
                }
                if(iTmp == 9)
                {
                    Console.WriteLine("\n\tTie!");
                    aTries[2]++;
                    for (int itr_0 = 0; itr_0 < 3; itr_0++)
                    {
                        for (int itr_1 = 0; itr_1 < 3; itr_1++)
                        {
                            m_avMat3x3[itr_0, itr_1] = value.NON;
                        }
                    }
                }
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
                    Console.WriteLine("{0,3}|{1,3}|{2,3}", m_avMat3x3[itr_0, 0], m_avMat3x3[itr_0, 1], m_avMat3x3[itr_0, 2]);
            }
            Console.WriteLine("\n\tX won {0} times.\n\tO won {1} times.", aTries[0], aTries[1]);
            Console.WriteLine("\tTies: " + aTries[2]);
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
                iHorizontal =  CRandom.Next(3);
                  iVertical =  CRandom.Next(3);
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
            int iAnswer = -1;
            ConsoleKeyInfo CKey;
            CKey = Console.ReadKey();
            switch (CKey.Key)
            {
                case ConsoleKey.D1:
                   iAnswer = 0;break;
                case ConsoleKey.D2:
                   iAnswer = 1;break;
                case ConsoleKey.D3:
                   iAnswer = 2;break;        
            }
            return iAnswer;
        }
        //выбирает ячейку и присвает ей Х
        public bool m_Input()   
        {
            int ivertical, ihorizontal;
            Console.WriteLine("\n\tВведите вертикальный номер ячейки(от 1 до 3): ");
            ivertical = m_iChecToint();
            Console.WriteLine("\n\tВведите горизонтальный номер ячейки(от 1 до 3): ");
            ihorizontal = m_iChecToint();           
            //проверка на вшивость
            if (ivertical != -1 && ihorizontal != -1)
            {
                if (m_avMat3x3[ihorizontal, ivertical] == value.NON)
                {
                    m_avMat3x3[ihorizontal, ivertical] = value.X;
                } return true;
            } else 
            {
                return false; } 
        }

    }
}
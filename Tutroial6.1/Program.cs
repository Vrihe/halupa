using System.Collections.Generic;
using System.Transactions;





namespace Tutroial6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //выделение памяти для массива
            //где цифра 5 выступает в роли колчества елементов
           //это одномерный массив
            int[] aNums = new int[5] ;


            //Отчёт в массивах начинается с 0
            //тоесть 1-е число это 0
            aNums[0] = 4;
            aNums[1] = 5;
            aNums[2] = 3;
            aNums[3] = 6;
            aNums[4] = 2;
            //для вывода в консоль информации касательно массива
            // нужно писать индекс елемента
            Console.WriteLine("Element: " + aNums[3]);

          
           
                short siSuma = 0;
                int[] aNumbers = new int[15];
                // класс рандом делает то как он называется
                    Random CKasino = new Random();
               
                
                //микро хуйня
                //Команда Length отвечает за то чтобы цикл повторялся столько раз
                //сколько значений в массиве(чтоб вручную не писать)
                //перед Length пишется название переменной для массива
                for (byte itr_0 = 0; itr_0 < aNumbers.Length; itr_0++) { 
                   
                    //это присвоение елементам массива случайных значений
                    // в диапазоне от 1 до 544
                    aNumbers[itr_0] = CKasino.Next(1, 544);
                    
                    
                
                //Переменная в квадратных скобках служит чтобы при каждом
                //круге цикла выводилось 1 значение из массива
                //соотвественно на превом круге будет 4 потом 5 и т.д.
          
                    Console.WriteLine("Elements: " + aNumbers[itr_0]);

                    siSuma +=Convert.ToInt16( aNumbers[itr_0]);
                }

                    Console.WriteLine("summa: " + siSuma);




            //вот это двумерный

            string[,] aWords = new string[8, 4];

            //также можно написать массив без выделения памяти
            // двеумерный массив, если можно так сказать составлен из 2 массивов
            // каждый из этих массивов отмечается фигурными скобками

            char[,] aChars = { {'a','b','c'}
                             , {'q','w','e'}
                             , {'z','x','c'} };
            //цикл foreach служит для того чтобы быстро перебрать все елементы в массиве
            foreach (char cWord in aChars)
            {
                Console.WriteLine("Elements: " + cWord);
                
                
                


            };

            //класс лист, нужен для динамических массивов, но как по мне кал
                List<int> aNomera = new List<int>()
                { 
                 4, 5, 6

                };

            //add добавляет в массив знчение в скобках
                aNomera.Add(80);
                aNomera.Add(110);
                aNomera.Add(8123);
                aNomera.Add(23);
            //remove соответсвенно убирает
                aNomera.Remove(23);

                foreach (int iElem in aNomera)
                {
                    Console.WriteLine("Elements: " + iElem);



                };
            





























        }
    }
}

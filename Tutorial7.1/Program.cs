namespace Tutorial7._1
{//методы также можно называть функциями, и наоборот
    internal class Program
    {
        //по стоку выполняется только метод Main
        //остальные же только при вызове 
        static void Main(string[] args)
        {//это пример самого банального вызова к методу/функции
         //метод можно вызывать несколько раз
         //также можно написать параметры для метода
            Console.WriteLine("введите значение");
            int iResult1 = iZalupa(Convert.ToInt32(Console.ReadLine()), 5, 7);
            Console.WriteLine("введите значение");
            int iA = Convert.ToInt32(Console.ReadLine()), iB = 8;
            int iResult2 = iZalupa(iB, iA, 20);
            vZalupa(iResult1.ToString());
            vZalupa(iResult2.ToString());


            byte[,] aNumbers = {{3,4,5},
                                {6,7,8},
                                {3,8,9} 
            };

            byte bResult1 = bMath(aNumbers);
            Console.WriteLine("result: " + bResult1);


            byte[,] aNumbers1 = {{31,4,54},
                                {6,75,85},
                                {33,8,94}
            };


            byte bResult2 = bMath(aNumbers1);
            Console.WriteLine("result: " + bResult2);















        }
        //Методы пишуться вне других методов
        //public это модификатор доступа
        //static нужен для того чтобы обращатся к методу при помощи названия
        //void модификатор который делает чтобы метод ничего не отдавал обратно
        //параметром может служить переменная или слово и их модет быть беск. кол-во

        public static void vZalupa(string sWoford)
        {

            Console.WriteLine(sWoford);
        } 
        public static int iZalupa (int iX, int iY, int iZ)
        {
            return iX + iY + iZ * 23;
        }






        public static byte bMath(byte[,] aDigitals)
        {

            byte bSumma = 0;
                foreach (byte bElem in aDigitals)
            {
                bSumma += bElem;

            }

            return bSumma;
        }













    }
}

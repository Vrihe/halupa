namespace Tutorial2._1
{
    internal class CTutorial2
    {
        static void Main()
        {
            int iNumber = -13;
            Console.WriteLine(iNumber);
            iNumber = 4;
            Console.WriteLine("ya togo rot ebal " + iNumber);
            iNumber = 1231312;
            Console.WriteLine("The third number is: " + iNumber + " Vse, idi nahuy.");

            //Только безнаковое целое число

            uint uNumber = 10;  
            Console.WriteLine(uNumber);

            //не целые типы переменных, в конце обязательно превая буква типа(относится и к значению)

            float fNumber = 12.31f;

            //Стринг используется для текстовой переменной

            string sWord = "zalupa";

            //Чтобы вывести несколько переменных, нужно писать через +

            Console.WriteLine(sWord + $"[{fNumber} {sWord} {uNumber}]" + " ya tvoyu matb ebal.");

            //char cSymbol = 'h'
            bool bPidor = true;
            bPidor = !bPidor;
            Console.WriteLine(bPidor);
            bPidor = !bPidor;
            Console.WriteLine(bPidor);
            
            //пользователь вводит значение для 2 пременных (iNum_1 и iNum_2) затем это
            //сумируеться и выводится в консоль

            int iNum_1, iNum_2, iNum_3;

            Console.WriteLine("\n\tВведите значение для 1 переменной");
            iNum_1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("\n\tВведите значение для 2 переменной");
            iNum_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\tСумма");
            iNum_3 = iNum_1 + iNum_2;

            Console.WriteLine(iNum_3);




            Console.ReadKey();
        }
    }
}

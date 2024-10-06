namespace Tutorial3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tВведите число с значениями после запятой: ");

            //Функция Convert не работает для типа Float поэтому нужно использовать float.Parse

            float fUser_input = float.Parse(Console.ReadLine());



            Console.WriteLine("\n\tЗначение пременной: ");
            Console.WriteLine(fUser_input);



             double fResult = fUser_input + 13d;

            //Можно ставить мат.знаки перед ровно чтобы не прописывать, например fResult = fResult + 5f и так далее

            fResult += 5d;
            //fResult -= 5f;
            // fResult %= 5f;
            // fResult /= 5f
            //fResult *= 5f;

            //Два плюса либо два минуса означает +1 и соответсвенно -1

            fResult++;
            fResult--;

            //Чтобы быстро написать Console.WriteLine(); можно напечатать cw и нажать клавишу Tab или Enter

            //Класс Math используется для разных мат. задач
            //например написание числа Пи при помощи константы PI
            //значение константы нельзя изменить

            // const int iNumber = 12 это как создать константу. в ВС есть встроенные по типу Пи Е.


            
            Console.WriteLine("Значение PI: ");
            Console.WriteLine(Math.PI);

            //Функция Abs позволяет выводить модуль числа
            //Ceiling служит для округления чисел к Большему 
            //Floor округляет числа к меньшему
            //Round просто округляет число, либо к большему либо к меньшему
            //Также есть функции косинуса синуса и другого пишуться соответсвенно cos sin и тд
            //Min, Max используються для определения меньшего или большего числа из 2 разных чисел
            //Pow исползуется для возведения в степень сначала пишется число которое нужно возвести
            //потом через кому степень в которую нужно возвести


            Console.WriteLine("\n\tМодуль числа: ");
            Console.WriteLine(Math.Abs(-fResult));
            Console.WriteLine("\n\tОкругление этого числа: ");
            Console.WriteLine(Math.Ceiling(fResult));
            Console.WriteLine(Math.Floor(fResult));
            Console.WriteLine(Math.Round(fResult));
            Console.WriteLine("\n\tВведите степень в которую хотите возвести ");
            int iPow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\tВозведение числа в степень: ");
            Console.WriteLine(Math.Pow(fResult, iPow));


            Console.WriteLine("\n\tВведите радиус круга");
            double diRadius = Convert.ToDouble(Console.ReadLine());
            double  diArea = Math.PI * Math.Pow(diRadius, 2);

            //При выводе инфы в консоль можно писать {и номер аргумента} например
            //радиус выступает в роли 0-го аргумента а площадь в поли 1-го

            Console.WriteLine("\n\tПлощадь круга с радиусом {0} равна {1}", diRadius, diArea);

             






            Console.ReadKey();
        }
    }
}

using System.ComponentModel.Design;
using System.Numerics;
using System.Threading.Channels;

namespace Tutorial4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tНапишите значение переменной");
            int iNumber_1 = Convert.ToInt32(Console.ReadLine());
            bool bLoh = true;
            Console.WriteLine("введите значение залупы");
            float fZalupa = float.Parse(Console.ReadLine());

            //Функция if проверяет заданое условие, если оно сходится то
            // выполняется код в фигурных скобках, можно приписать несколько условий if
            //== означает проверку равно ли число заданому,!= означает не равно, все знаки для этой команды: !=,==,<,>,<=,>=.
            //&& для условий это означает "и", вот эти палки ебучие || означают "или".
            // для || неважно если 1 из сторон будет неверной, главное чтобы хотя бы одна прошла по критериям


            if (iNumber_1 == 4)
            {

                Console.WriteLine("Пременная равна 4-ём");

            }

            //для одиночных команд в else, if, else if не нужно ставить фигурные скобки
            else if (iNumber_1 == 6 && bLoh)
                Console.WriteLine("Ты давай, нахуй иди");
           
           

            //для условий можно дописывать дополнительные условия

            else if ((iNumber_1 != 3 && fZalupa > 3) && bLoh)
            {
                Console.WriteLine("пиздабол");
                Console.WriteLine("днд хуйня");



            }

            //микро прога


            Console.WriteLine("Напишите свою роль");
            string sRole = Console.ReadLine();

            if (sRole == "Admin") {
                Console.WriteLine("Введите название учётной записи");
                string sUser = Console.ReadLine();
                Console.WriteLine("Введите пароль от {0}: ", sUser);
                short siPassword = Convert.ToInt16(Console.ReadLine());
                if (siPassword == 4423)
                {
                    Console.WriteLine("Welcome " + sUser);
                    Console.WriteLine("Хочешь я покажу твою судьбу в будущем?");
                    string sAnswer = Console.ReadLine();
                    if (sAnswer == "да")
                    {
                        Console.WriteLine("тебя сбила машина, лох");
                    }
                    else
                        Console.WriteLine("ну и шагай ты нахуй");
                }
                else
                {
                    Console.WriteLine("Неправильный пароль!Пиши оправдания: ");
                    string sOprav = Console.ReadLine();
                    if (sOprav == "иди нахуй")
                    {
                        Console.WriteLine("Сам иди, чмо");
                    }else 
                    
                        Console.WriteLine("Да мне похуй ес чё, у тебя мать здохла");




                }
            
            }else
                Console.WriteLine("Иди нахуй");
            Console.WriteLine("Напишите значение переменной");

            short isNumber_2 = Convert.ToInt16(Console.ReadLine());

            //switch-case это тоже самое что и if-else только с 1 переменной и множеством случаев
            // если эта переменная проходит по условиям
            //оператор default это тоже самое что и else только для switch-case
        
            switch (isNumber_2)
            {
                case 5:
                    Console.WriteLine("цыфра равна 5-ти"); break;
                case 10:
                    Console.WriteLine("10"); 
                    break;
                case 15:
                    Console.WriteLine("15"); 
                    break;
                case 20:
                    Console.WriteLine("20"); 
                    break;
                case 25:
                    Console.WriteLine("25");
                    break;
                default:
                    Console.WriteLine("ди наху"); 
                    break;
                   
            }



















            Console.ReadKey();
        }
    }
}

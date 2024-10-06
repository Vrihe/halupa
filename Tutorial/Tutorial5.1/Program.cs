namespace Tutorial5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("введите значение");
            float fNumber = float.Parse(Console.ReadLine());

            //а цикл for хуйня


            for (; fNumber > 5.0f; fNumber--)
            {
                Console.WriteLine("Значение {0}", fNumber);

                bool bPidr = true;

                //переменная bool всегда должна быть со значением true 
                //чтобы цикл выполнялся

                //цикл будет идти до тех пор пока не значение не достигнет требуемого

                while (bPidr)
                {


                    Console.WriteLine("ты пидор?");

                    string sEnd = Console.ReadLine();

                    if (sEnd == "ладно я пидор")
                    {
                        bPidr = false;

                    }


                    //Цикл будет идти до тех пор пока значение while будет неверным
                    do
                    {
                        Console.WriteLine("Значение переменной: " + fNumber);
                        fNumber--;
                    } while (fNumber <= 4 && fNumber >= -4);

                    //оператор break может завершать циклы
                    //только писать его нужно через if

                    //continue пропускает 1 круг цикла при выполнении условий if
                }
            }
        }
    }
}
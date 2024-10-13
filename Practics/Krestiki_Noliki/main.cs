using X_O;

namespace main
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            //переменная которая отвечает за 
            //хранение данных нажатых клавиш
            ConsoleKeyInfo CKey;
           
            //переменная которая отвечает за цикл
            //цикл конец = после нажатия Esc
            bool bKey_1 = true;

            CX_O CGame = new CX_O();
          

            //главный цикл
            while (bKey_1)
            {
              CGame.m_update();


            }

        }
    }
}

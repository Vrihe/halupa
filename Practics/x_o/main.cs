using X_O;

namespace main
{
    internal class main
    {

        static void Main(string[] args)
        {
            //переменная которая отвечает за цикл
            //цикл конец = после нажатия Esc
            bool bKey_1 = true;
            logic CGame = new logic();

            //главный цикл
            while (bKey_1)
            {
                CGame.m_update();
            }
        }
    }
}

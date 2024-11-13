namespace x_o_UI
{   static class G
    {
        public static Form1 FormMain;
    }
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            G.FormMain = new Form1();       
            Application.Run(G.FormMain);
        }
    }
}
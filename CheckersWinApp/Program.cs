using System;

namespace CheckersWinApp
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            CheckersApplication app = new CheckersApplication();

            app.Run();
        }
    }
}

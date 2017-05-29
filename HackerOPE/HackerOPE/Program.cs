using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HackerOPE
{
    class Program
    {
        public static Boolean quit = false;
        static void Main(string[] args)
        {
            GameManager.ShowTitleScreen();
            Level.Initialize();
            GameManager.StartGame();

            while (!quit)
            {
                CommandProcessor.ProcessCommand(Console.ReadLine());
            }

            
        }
    }
}

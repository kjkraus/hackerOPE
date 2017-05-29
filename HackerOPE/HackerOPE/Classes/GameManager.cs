using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerOPE
{
    static class GameManager
    {
        // Public Methods
        public static void ShowTitleScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(TextUtils.WordWrap("*** PUzzle Game framework ***\n\n\n", 
                                                 Console.WindowWidth));
            Console.WriteLine("\nNOTE: You may type 'help' at anytime");
            Console.WriteLine("\nPress any key to begin.");

            Console.CursorVisible = false;
            Console.ReadKey();
            Console.CursorVisible = true;
            Console.Clear();
        }

        public static void StartGame()
        {
            Player.GetCurrentRoom().Describe();
            TextBuffer.Display();
        }

        public static void EndGame(string endingText)
        {
            Program.quit = true;

            Console.Clear();
            Console.WriteLine(TextUtils.WordWrap(endingText, Console.WindowWidth));
            Console.WriteLine("You may close the window.");
            Console.CursorVisible = false;

            while (true)
                Console.ReadKey(true);
        }

        public static void ApplyRules()
        {
            if (Level.Rooms[0, 0].GetItem("Red Ball")  != null &&
                Level.Rooms[1, 0].GetItem("Blue Ball") != null &&
                Level.Rooms[1, 1].GetItem("Yellow Ball") != null &&
                Level.Rooms[0, 1].GetItem("Green Ball") != null)
                {
                EndGame("You've won!");
                }

            if (Player.GetInventoryItem("Key") != null)
            {
                Level.Rooms[0, 0].AddExit(Direction.South); //red room
                Level.Rooms[0, 0].Description = "You have entered the red room.";

                Level.Rooms[0, 1].AddExit(Direction.North); //green room
                Level.Rooms[0, 1].Description = "You have entered the green room.";
            }

            if (Player.Moves > 10)
            {
                EndGame("You are too slow. Game Over!");
            }
        }


        
    }
}

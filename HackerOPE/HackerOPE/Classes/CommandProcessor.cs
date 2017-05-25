using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerOPE
{
    static class CommandProcessor
    {
        public static void ProcessCommand(string line)
        {
            string command = TextUtils.ExtractCommand(line.Trim()).Trim().ToLower();
            string arguments = TextUtils.ExtractArguments(line.Trim()).Trim().ToLower();
        

        public static void ShowHelp()
        {
            switch (command)
            {
                case "exit":
                    Program.quit = true;
                    return;
                case "help":
                    ShowHelp();
                    break;
                case "move":
                    Player.Move(arguments);
                    break;
                case "look":
                    Player.GetCurrentRoom().Describe();
                    break;
                case "pickup":
                    Player.PickupItem(arguments);
                    break;
                case "drop":
                    Player.DropItem(arguments);
                    break;
                case "inventory":
                    Player.DisplayInventory(arguments);
                    break;
                case "whereami":
                    Player.GetCurrentRoom().ShowTitle();
                    break;
                default:
                    TextBuffer.Add("Input not understood.");
                    break;
                }

            }
        }
    }
}

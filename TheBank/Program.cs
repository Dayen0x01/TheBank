using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank
{
    internal class Program
    {
        
        static void DrawLogo()
        {
            Console.WriteLine(" /$$$$$$$$ /$$                 /$$$$$$$                      /$$      ");
            Console.WriteLine("|__  $$__/| $$                | $$__  $$                    | $$      ");
            Console.WriteLine("   | $$   | $$$$$$$   /$$$$$$ | $$  \\ $$  /$$$$$$  /$$$$$$$ | $$   /$$");
            Console.WriteLine("   | $$   | $$__  $$ /$$__  $$| $$$$$$$  |____  $$| $$__  $$| $$  /$$/");
            Console.WriteLine("   | $$   | $$  \\ $$| $$$$$$$$| $$__  $$  /$$$$$$$| $$  \\ $$| $$$$$$/ ");
            Console.WriteLine("   | $$   | $$  | $$| $$_____/| $$  \\ $$ /$$__  $$| $$  | $$| $$_  $$ ");
            Console.WriteLine("   | $$   | $$  | $$|  $$$$$$$| $$$$$$$/|  $$$$$$$| $$  | $$| $$ \\  $$");
            Console.WriteLine("   |__/   |__/  |__/ \\_______/|_______/  \\_______/|__/  |__/|__/  \\__/");
            Console.WriteLine("                                          {Bank system by Ney Damé}");
        }

        static void drawMenu()
        {
            Console.WriteLine("\n## OPTIONS ##\n1 - Add Account\n2 - List Accounts\n3 - List Transfers\n4 - Transfer to");

            string command = Console.ReadLine();

            if (Commands.commandsList.Keys.Contains(command))
            {
                Commands.commandsList[command].Invoke();
            }

            drawMenu();
        }
        static void Main(string[] args)
        {
            Console.Title = "TheBank";
            DrawLogo();
            Commands.registerCommands();
            drawMenu();

            Console.Read();
        }
    }
}

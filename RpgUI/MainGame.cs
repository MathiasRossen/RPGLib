using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGLib;
using RPGUI.Areas;

namespace RPGUI
{
    class MainGame
    {
        Player player;
        bool running;
        IArea startingArea;

        public MainGame()
        {
            running = true;

            player = new Player("Hero");
            startingArea = new TownVille();

            player.Location = startingArea;
        }

        public void Run()
        {
            string input;

            do
            {
                Console.Clear();
                DisplayMainMenu();
                input = GetUserInput();
                SwitchMainMenuChoice(input);
            }
            while (running);
        }

        private string GetUserInput()
        {
            return Console.ReadLine();
        }

        private void DisplayMainMenu()
        {
            Console.WriteLine("{0}\tLocation: {1}\tDay: 1", player.Name, player.Location.Name);
            Console.WriteLine();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Adventure");
            Console.WriteLine("2. Shop");
        }

        private void SwitchMainMenuChoice(string input)
        {
            Console.Clear();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Adventure block");
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("Shop block");
                    Console.ReadLine();
                    break;

                case "0":
                    Console.WriteLine("Exiting game");
                    Console.ReadLine();
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    Console.ReadLine();
                    break;
            }
        }

        private void DisplayAdventureMenu()
        {

        }
    }
}

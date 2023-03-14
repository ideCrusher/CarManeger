using System;
using System.IO;

namespace car
{
    internal class Program
    {
        static Player _Player;
        static void Main(string[] args)
        {
            int p = 0;
            while (p < 1)
            {
                Console.WriteLine("Введите команду.");
                string s = Console.ReadLine();
                if (s == "-Get_Car")
                {
                    _Player.Get_PlayerCar();
                }
                else if (s == "-New_Player")
                {
                    Console.WriteLine("Read name:");
                    string Name = Console.ReadLine();

                    _Player = new Player(Name);

                    Console.WriteLine("New player created:");
                    _Player.Get_Player();
                }
                else if (s == "-Get_Player")
                {
                    _Player.Get_Player();
                }
                else if (s == "-Exit")
                {
                    _Player.Player_Save();
                    Environment.Exit(0);
                }
                else if (s == "-help")
                {
                    Console.WriteLine($"Welcome to Racing simulator.\n" +
                        "Available command:\n" +
                        "-help - View command, \n" +
                        "-New_Player - create new profile,\n" +
                        "-Get_Car - View player car,\n" +
                        "-Get_Player - Vier player profile,\n" +
                        "" +
                        "-Exit - Exit.");                        
                }
            }
        }

        static void Starter()
        {

        }
    }
}

using System;

namespace homeWorkConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string СommandConsoleEnterName = "1";
            const string СommandConsoleEnterAge = "2";
            const string СommandConsoleShowNumber = "3";
            const string СommandConsoleClearConsole = "4";
            const string СommandConsoleExit = "5";

            string inputUser;
            bool toExit = true;

            while (toExit)
            {
                Console.WriteLine("Choose menu item: ");
                Console.WriteLine($"{СommandConsoleEnterName}. Enter your name;");
                Console.WriteLine($"{СommandConsoleEnterAge}. Enter your age;");
                Console.WriteLine($"{СommandConsoleShowNumber}. Show me random number;");
                Console.WriteLine($"{СommandConsoleClearConsole}. Clear console;");
                Console.WriteLine($"{СommandConsoleExit}. Exit to the programm;");

                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case СommandConsoleEnterName:
                        Console.Write("Enter your name please: ");
                        string name = Console.ReadLine();
                        Console.WriteLine($"Your name is {name}");
                        break;
                    case СommandConsoleEnterAge:
                        Console.Write("Enter your age please: ");
                        string age = Console.ReadLine();
                        Console.WriteLine($"Your age is {age}");
                        break;
                    case СommandConsoleShowNumber:
                        int minValue = -100;
                        int maxValue = 100;
                        Random random = new Random();
                        Console.WriteLine(random.Next(minValue, maxValue));
                        break;
                    case СommandConsoleClearConsole:
                        Console.Clear();
                        break;
                    case СommandConsoleExit:
                        toExit = false;
                        break;
                }
            }
        }
    }
}

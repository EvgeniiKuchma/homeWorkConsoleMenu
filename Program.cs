using System;

namespace homeWorkConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string commandConsoleEnterName = "1";
            const string commandConsoleEnterAge = "2";
            const string commandConsoleShowNumber = "3";
            const string commandConsoleClearConsole = "4";
            const string commandConsoleExit = "5";

            string inputUser;
            bool toExit = true;

            while (toExit)
            {
                Console.WriteLine("Choose menu item: ");
                Console.WriteLine("1. Enter your name;");
                Console.WriteLine("2. Enter your age;");
                Console.WriteLine("3. Show me random number;");
                Console.WriteLine("4. Clear console;");
                Console.WriteLine("5. Exit to the programm;");

                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case commandConsoleEnterName:
                        Console.Write("Enter your name please: ");
                        string name = Console.ReadLine();
                        Console.WriteLine($"Your name is {name}");
                        break;
                    case commandConsoleEnterAge:
                        Console.Write("Enter your age please: ");
                        string age = Console.ReadLine();
                        Console.WriteLine($"Your age is {age}");
                        break;
                    case commandConsoleShowNumber:
                        int minValue = -100;
                        int maxValue = 100;
                        Random random = new Random();
                        Console.WriteLine(random.Next(minValue, maxValue));
                        break;
                    case commandConsoleClearConsole:
                        Console.Clear();
                        break;
                    case commandConsoleExit:
                        toExit = false;
                        break;
                }
            }
        }
    }
}

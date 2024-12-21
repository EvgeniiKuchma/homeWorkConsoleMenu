using System;

namespace homeWorkConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputUser;
            bool toExit = true;

            while (toExit)
            {
                Console.WriteLine("Choose menu item: ");
                Console.WriteLine("1. Enter your name;");
                Console.WriteLine("2. Enter your age;");
                Console.WriteLine("3. Show me random number;");
                Console.WriteLine("4. Clear console;");
                Console.WriteLine("5. Exit to the programm;");

                inputUser = Convert.ToInt32(Console.ReadLine());

                switch (inputUser)
                {
                    case 1:
                        Console.Write("Enter your name please: ");
                        string name = Console.ReadLine();
                        Console.WriteLine($"Your name is {name}");
                        break;
                    case 2:
                        Console.Write("Enter your age please: ");
                        string age = Console.ReadLine();
                        Console.WriteLine($"Your age is {age}");
                        break;
                    case 3:
                        int minValue = -100;
                        int maxValue = 100;
                        Random random = new Random();
                        Console.WriteLine(random.Next(minValue, maxValue));
                        break;
                    case 4:
                        Console.Clear();
                        break;
                    case 5:
                        toExit = false;
                        break;
                }
            }
        }
    }
}

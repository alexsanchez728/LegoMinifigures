using System;
using LegoMinifigures.Figures;


namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;

            Console.WriteLine("Press (ESC) to close");

            var LegoGuy1 = new Figurine
            {
                Topper = "Red Cap",
                Head = "Angry Eyes",
                Toroso = "Adventurer",
                Legs = "Brown",
                Accessories = "Pickaxe"
            };
            LegoGuy1.Display();
        do
        {
            cki = Console.ReadKey(true); // intercept = true; so keypress doesn't print
                if (cki.Key == ConsoleKey.W)
                {
                    LegoGuy1.MoveForward();
                }
                if (cki.Key == ConsoleKey.S)
                {
                    LegoGuy1.MoveBackward();
                }
                if (cki.Key == ConsoleKey.A)
                {
                    LegoGuy1.MoveLeft();
                }
                if (cki.Key == ConsoleKey.D)
                {
                    LegoGuy1.MoveRight();
                }
                if (cki.Key == ConsoleKey.Q)
                {
                    LegoGuy1.Attack();
                }
                if (cki.Key == ConsoleKey.Spacebar)
                {
                    LegoGuy1.Jump();
                }
                if (cki.Key == ConsoleKey.Enter)
                {
                    LegoGuy1.Unlocks();
                }
                if (cki.Key == ConsoleKey.LeftArrow)
                {
                    LegoGuy1.LookLeft();
                }
                if (cki.Key == ConsoleKey.RightArrow)
                {
                    LegoGuy1.LookRight();
                }
                if (cki.Key == ConsoleKey.UpArrow)
                {
                    LegoGuy1.LookUp();
                }
                if (cki.Key == ConsoleKey.DownArrow)
                {
                    LegoGuy1.LookDown();
                }
            } while (cki.Key != ConsoleKey.Escape);

        }
    }
}

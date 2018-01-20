using System;
using LegoMinifigures.Figures;


namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
 
            var LegoGuy1 = new Figurine
            {
                Topper = "Red Cap",
                Head = "Angry Eyes",
                Toroso = "Adventurer",
                Legs = "Brown",
                Accessories = "Pickaxe"
            };
            LegoGuy1.Display();

            while (true)
            {
                var userInput = Console.ReadLine();
                if (userInput == "w")
                {
                    LegoGuy1.MoveForward();
                }
                else if (userInput == "s")
                {
                    LegoGuy1.MoveBackward();
                }
                else if (userInput == "a")
                {
                    LegoGuy1.MoveLeft();
                }
                else if (userInput == "d")
                {
                    LegoGuy1.MoveRight();
                }
                else if (userInput == "q")
                {
                    LegoGuy1.Attack();
                }
                else if (userInput == "qq")
                {
                    LegoGuy1.SpecialAttack();
                }
                else if (userInput == " ")
                {
                    LegoGuy1.Jump();
                }
                else if (userInput == "  ")
                {
                    LegoGuy1.DoubleJump();
                }
                else if (userInput == "secret")
                    {
                    LegoGuy1.Unlocks();
                }
            }
        }
    }
}

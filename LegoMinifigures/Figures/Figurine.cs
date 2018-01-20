using System;

namespace LegoMinifigures.Figures
{
    class Figurine
    {
        //Hair/Hat, Head, Torso, Legs, Accessories, etc.
        public string Topper { get; set; }
        public string Head { get; set; }
        public string Toroso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }

        public void Display()
        {
            Console.WriteLine("Your Lego Figure:");
            Console.WriteLine($"Topper: {Topper}");
            Console.WriteLine($"Head: {Head}");
            Console.WriteLine($"Toroso: {Toroso}");
            Console.WriteLine($"Legs: {Legs}");
            Console.WriteLine($"Accessories: {Accessories}");
        }

        public string MoveForward()
        {
            Console.WriteLine("Forward!");
            return "forward";
        }
        public string MoveBackward()
        {
            Console.WriteLine("Back!");
            return "back";
        }
        public string MoveLeft()
        {
            Console.WriteLine("Left!");
            return "left";
        }
        public string MoveRight()
        {
            Console.WriteLine("Right!");
            return "right";
        }
        public string Attack()
        {
            Console.WriteLine("Attack!");
            return "attack";
        }
        public string SpecialAttack()
        {
            Console.WriteLine("SUPER!");
            return "Special attack";
        }
        public string Jump()
        {
            Console.WriteLine("Jump!");
            return "jump";
        }
        public string DoubleJump()
        {
            Console.WriteLine("DOUBLE JUMP!");
            return "double jump";
        }
        public string LookLeft()
        {
            Console.WriteLine("looking left");
            return "left";
        }
        public string LookRight()
        {
            Console.WriteLine("looking right");
            return "right";
        }
        public string LookUp()
        {
            Console.WriteLine("looking up");
            return "up";
        }
        public string LookDown()
        {
            Console.WriteLine("looking down");
            return "down";
        }
        public string Unlocks()
        {
            Accessories += ", Batmobile";
            Display();
            return "unlocked";
        }


        //            Methods
        //If you were working at Tt Games, 
        //            your minifigure classes might have actions associated with them in the form of:
        //            ~> jump,
        //            ~> double jump,
        //            ~> attack,
        //            ~> special attack,
        //            ~> look,
        //            ~> move methods.
        //There might even be certain conditions that must be met to
        //            construct (or unlock) a new character or other kind of object.
    }
}

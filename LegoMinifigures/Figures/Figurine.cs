using System;

namespace LegoMinifigures.Figures
{
    class Figurine
    {
        //Hair/Hat, Head, Torso, Legs, Accessories, etc.
        protected string _topper;
        protected string _head;
        protected string _toroso;
        protected string _legs;
        protected string _accessories;

        public string Topper
        {
            get
            {
                return _topper;
            }
            set
            {
                _topper = value;
            }
        }
        public string Head
        {
            get
            {
                return _head;
            }
            set
            {
                _head = value;
            }
        }
        public string Toroso
        {
            get
            {
                return _toroso;
            }
            set
            {
                _toroso = value;
            }
        }
        public string Legs
        {
            get
            {
                return _legs;
            }
            set
            {
                _legs = value;
            }
        }
        public string Accessories
        {
            get
            {
                return _accessories;
            }
            set
            {
                _accessories = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("Your Lego Figure:");
            Console.WriteLine($"Topper: {_topper}");
            Console.WriteLine($"Head: {_head}");
            Console.WriteLine($"Toroso: {_toroso}");
            Console.WriteLine($"Legs: {_legs}");
            Console.WriteLine($"Accessories: {_accessories}");
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
        public string Jump()
        {
            Console.WriteLine("Jump!");
            return "jump";
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
            _accessories += ", Batmobile";
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

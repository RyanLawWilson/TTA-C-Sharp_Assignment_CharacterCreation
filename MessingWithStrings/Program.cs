using System;
using System.Text;

namespace CharacterCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            awesomeWrite("Welcome to character creation!\n", 40);
            awesomeWrite("Check each category and change your character's attributes\n", 20);
            System.Threading.Thread.Sleep(500);

            // Default Character attributes:
            string name = "Link";
            string height = "5ft 8in";
            string armor = "light";
            string weapon = "Sword and Shield";

            bool creatingCharacter = true;

            // Keep giving the option to edit character until player types 'done'
            while (creatingCharacter)
            {
                // Show the Players character
                awesomeWrite("\n\tYour Character\n", 10);
                awesomeWrite("=============================\n", 10);
                awesomeWrite("Name:   " + name.ToUpper() + "\nHeight: " + height + "\nArmor:  " + armor + "\nWeapon: " + weapon + "\n\n", 10);

                awesomeWrite("Type 'done' when finished.  What do you want to change? (Name, Height, etc.): ");
                string category = Console.ReadLine();

                if (category == "Name" || category == "name")
                {
                    awesomeWrite("What is your character's name?: ");
                    name = Console.ReadLine();
                }
                else if (category == "Height" || category == "height")
                {
                    awesomeWrite("What is your character's height?: ");
                    height = Console.ReadLine();
                }
                else if (category == "Armor" || category == "armor")
                {
                    awesomeWrite("What is your character's armor type?: ");
                    armor = Console.ReadLine();
                }
                else if (category == "Weapon" || category == "weapon")
                {
                    awesomeWrite("What weapon does your character use?: ");
                    weapon = Console.ReadLine();
                }
                else if (category == "Done" || category == "done")
                {
                    creatingCharacter = false;
                }
                else
                {
                    awesomeWrite("I don't recognize " + category + ".  Please try again.\n");
                }
            }

            System.Threading.Thread.Sleep(500);
            // Using StringBuilder
            StringBuilder characterSummary = new StringBuilder();
            characterSummary.Append("\nYour character: \nOnce upon a time there was a person named " + name.ToUpper() +
                "\nThey were only " + height + " tall." +
                "They brandished some " + armor + " armor\nand " + weapon + " for a weapon\n");
            awesomeWrite(characterSummary.ToString(), 30);

            System.Threading.Thread.Sleep(500);

            awesomeWrite("\nThanks for playing!");
            Console.Read();
        }

        // A method that types your string letter by letter.
        static void awesomeWrite(string text)
        {
            char[] letters = text.ToCharArray();
            foreach (char letter in letters)
            {
                System.Threading.Thread.Sleep(15);
                Console.Write(letter);
            }
        }

        // Overloaded method.  Allows you to change the speed that characters appear.  Bigger number = slower. 5 < speed < 100
        static void awesomeWrite(string text, int speed)
        {
            if (speed < 5 || speed > 100)
            {
                speed = 15;
            }
            char[] letters = text.ToCharArray();
            foreach (char letter in letters)
            {
                System.Threading.Thread.Sleep(speed);
                Console.Write(letter);
            }
        }
    }
}

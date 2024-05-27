using System;

namespace Bin_Test
{
    public class Pet_Attributes
    {
        int Hunger;
        int Happiness;
        int Health;

        public static void Main(string[] args)
        {
            SelectPet();
            NameYourPet();
            MainManu();
        }

        public static int SelectPet()
        {
            Console.WriteLine("Please choose a type of pet:");
            Console.WriteLine("1. Monkey");
            Console.WriteLine("2. Elephant");
            Console.WriteLine("3. Tiger");
            Console.WriteLine("");
            Console.Write("Please select: ");
            int Pet = int.Parse(Console.ReadLine());
            if (Pet != 1 && Pet != 2 && Pet != 3)
                ExceptionHandlingForPet();
            return Pet;
        }

        public static string NameYourPet()
        {
            String[] PetSelection = {"Monkey", "Elephant", "Tiger"};
            Console.WriteLine("You've chosen a {PetSelection[SelectPet()]}. What would you like to name your pet?");
            Console.Write("Input a name: ");
            String PetName = Console.ReadLine();
            Console.WriteLine("Welcome, " + PetName + "!" + "Let's take good care of him.");
            return PetName;
                
         }

        public static void MainManu() {
            Console.WriteLine("Main Manu:");
            Console.WriteLine("1. Feed " + NameYourPet());
            Console.WriteLine("2. Play with " + NameYourPet());
            Console.WriteLine("3. Let " + NameYourPet() + " Rest");
            Console.WriteLine("4. Check " + NameYourPet() + "'s Status");
            Console.WriteLine("5. Exit");
            Console.Write("Please select: ");

        }

        public static void ExceptionHandlingForPet()
        {
            Console.WriteLine("The number you input is wrong!!!");
            SelectPet();
        }
    }
}

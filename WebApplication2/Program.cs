using System;
using System.Runtime.CompilerServices;

namespace Bin_Test
{
    public class Pet_Attributes
    {

        public static void Main(string[] args)
        {
            int PetNum = SelectPet();
            string PetName = NameYourPet(PetNum);
            MainManu(PetName);
                
        }

        public static int SelectPet()
        {
            Console.WriteLine("Please choose a type of pet:");
            Console.WriteLine("1. Monkey");
            Console.WriteLine("2. Elephant");
            Console.WriteLine("3. Tiger");
            Console.WriteLine();
            Console.Write("Please select: ");
            int Pet = int.Parse(Console.ReadLine());
            if (Pet < 1 && Pet > 3)
                ExceptionHandlingForPet();
            return Pet;
        }

        public static string NameYourPet(int PetNum)
        {
            String[] PetSelection = {"Monkey", "Elephant", "Tiger"};
            Console.WriteLine();
            Console.WriteLine("You've chosen a(n) " + PetSelection[(PetNum)-1] + ". What would you like to name your pet?");
            Console.WriteLine();
            Console.Write("Input a name: ");
            String PetName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Welcome, " + PetName + "! " + "Let's take good care of him.");
            Console.WriteLine();
            return PetName; 
                
         }

        public static void MainManu(string PetName) {
            Console.WriteLine("Main Manu:");
            Console.WriteLine("1. Feed " + PetName);
            Console.WriteLine("2. Play with " + PetName);
            Console.WriteLine("3. Let " + PetName + " Rest");
            Console.WriteLine("4. Check " + PetName + "'s Status");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("Please select: ");
            int ManuInput = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (ManuInput < 1 && ManuInput > 5)
                ExceptionHandlingForMainManu(PetName);
            StatusOfPet(ManuInput, 5, 5, 5, PetName);

        }

        public static void StatusOfPet (int Input, int Hunger, int Happiness, int Health, string Name)
        {
            if (Input == 1) {
                Hunger--;
                Health++;
                Console.WriteLine("You fed " + Name + ". His hunger decreases, and health improves slightly.");
                Console.WriteLine();
                MainManu(Name);
            }

            else if (Input == 2)
            {
                Happiness++;
                Hunger++;
                Console.WriteLine("You played with " + Name + ". His happiness increases, but he is a bit hungrier.");
                Console.WriteLine();
                MainManu(Name);
            }

            else if (Input == 3)
            {
                Health++;
                Happiness--;
                Console.WriteLine("You let " + Name + " rest. His health increases, but he is becoming less happy.");
                Console.WriteLine();
                MainManu(Name);
            }

            else if (Input == 4)
            {
                Hunger--;
                Health++;
                Console.WriteLine(Name + "'s status:");
                Console.WriteLine("- Hunger: " + Hunger);
                Console.WriteLine("- Happiness: " + Happiness);
                Console.WriteLine("- Health: " + Health);
                Console.WriteLine();
                MainManu(Name);
            }

            else
            {
                Console.WriteLine("Thank you for playing with " + Name + ". Have a good day. Goodbye!");
                Console.WriteLine();
            }

        }

        public static void ExceptionHandlingForPet()
        {
            Console.WriteLine("The number you input is wrong!!!");
            SelectPet();
        }

        public static void ExceptionHandlingForMainManu(string PetName)
        {
            Console.WriteLine("The number you input is wrong!!!");
            MainManu(PetName);
        }
    }
}

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Bin_Test
{
    public class Pet_Attributes
    {
        /* Main Function: Initializaion for the variables. Including the whole process: Select pet/Name pet/User's activities.*/
        public static void Main(string[] args)
        {
            int Hunger = 5;
            int Happiness = 5;
            int Health = 5;
            int PetNum = SelectPet();
       
            string PetName = NameYourPet(PetNum);
            MainManu(PetName, Hunger, Happiness, Health);
                
        }
        /*List 3 pet manu and ask users to select one.*/
        public static int SelectPet()
        {
            Console.WriteLine("Please choose a type of pet:");
            Console.WriteLine("1. Monkey");
            Console.WriteLine("2. Elephant");
            Console.WriteLine("3. Tiger");
            Console.WriteLine();
            Console.Write("Please select: ");

            int Pet;

            try
            {
                Pet = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please input numeric charactors!!");
                Console.WriteLine();
                return SelectPet();

            }


            if (Pet < 1 || Pet > 3)
                {
                    WarningForInputCorrectNumber();
                    return SelectPet();
                }

            else
                return Pet;
          
        }

        /*Name the pet.*/
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

        /*Show the main manu of 5 activities.*/
        public static int MainManu(string PetName, int Hunger, int Happiness, int Health) {
            Console.WriteLine("Main Manu:");
            Console.WriteLine("1. Feed " + PetName);
            Console.WriteLine("2. Play with " + PetName);
            Console.WriteLine("3. Let " + PetName + " Rest");
            Console.WriteLine("4. Check " + PetName + "'s Status");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("Please select: ");
            int ManuInput;

            try
            {
                ManuInput = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please input numeric charactors!!");
                Console.WriteLine();
                MainManu(PetName, Hunger, Happiness, Health);
                return 0;
            }

            if (ManuInput < 1 || ManuInput > 5)
            {
                WarningForInputCorrectNumber();
                Console.WriteLine();
                MainManu(PetName, Hunger, Happiness, Health);
                return 0;
            }
            StatusOfPet(ManuInput, Hunger, Happiness, Health, PetName);
            return 0;

        }

        /*Behaviors for each activity.*/
        public static void StatusOfPet (int Input, int Hunger, int Happiness, int Health, string Name)
        {
            if (Input == 1) {
                Hunger--;
                Health++;
                Console.WriteLine("You fed " + Name + ". His hunger decreases, and health improves slightly.");
                Console.WriteLine();
                MainManu(Name, Hunger, Happiness, Health);
            }

            else if (Input == 2)
            {
                Happiness++;
                Hunger++;
                Console.WriteLine("You played with " + Name + ". His happiness increases, but he is a bit hungrier.");
                Console.WriteLine();
                MainManu(Name, Hunger, Happiness, Health);
            }

            else if (Input == 3)
            {
                Health++;
                Happiness--;
                Console.WriteLine("You let " + Name + " rest. His health increases, but he is becoming less happy.");
                Console.WriteLine();
                MainManu(Name, Hunger, Happiness, Health);
            }

            else if (Input == 4)
            {
                Console.WriteLine(Name + "'s status:");
                Console.WriteLine("- Hunger: " + Hunger);
                Console.WriteLine("- Happiness: " + Happiness);
                Console.WriteLine("- Health: " + Health);
                Console.WriteLine();
                MainManu(Name, Hunger, Happiness, Health);
            }

            else
            {
                Console.WriteLine("Thank you for playing with " + Name + ". Have a good day. Goodbye!");
                Console.WriteLine();
            }

        }

        /*Warning message for wrong number input.*/
        public static void WarningForInputCorrectNumber()
        {
            Console.WriteLine("The number you input is wrong!!!");
            Console.WriteLine();
        }

    }
}

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
            Console.WriteLine("");
            Console.Write("Please select: ");
            int Pet = int.Parse(Console.ReadLine());
            if (Pet < 1 && Pet > 3)
                ExceptionHandlingForPet();
            return Pet;
        }

        public static string NameYourPet(int PetNum)
        {
            String[] PetSelection = {"Monkey", "Elephant", "Tiger"};
/*            Console.WriteLine(PetSelection[(PetNum) - 1]);*/
            Console.WriteLine("You've chosen a(n) " + PetSelection[(PetNum)-1] + ". What would you like to name your pet?");
            Console.Write("Input a name: ");
            String PetName = Console.ReadLine();
            Console.WriteLine("Welcome, " + PetName + "! " + "Let's take good care of him.");
            return PetName; 
                
         }

        public static void MainManu(string PetName) {
            Console.WriteLine("Main Manu:");
            Console.WriteLine("1. Feed " + PetName);
            Console.WriteLine("2. Play with " + PetName);
            Console.WriteLine("3. Let " + PetName + " Rest");
            Console.WriteLine("4. Check " + PetName + "'s Status");
            Console.WriteLine("5. Exit");
            Console.Write("Please select: ");
            int ManuInput = int.Parse(Console.ReadLine());
            if (ManuInput < 1 && ManuInput > 5)
                ExceptionHandlingForMainManu(PetName);

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

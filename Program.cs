using System;
using System.Collections.Generic;

namespace Lesson6HomeworkApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create cost variables
            int FishCost = 0;
            int ChipsCost = 0;
            int TotalBill = 0;
     
            //Opening Dialog
            OpenDialog();

            //Ulga Dialog and user Interaction for Fish
            OrderFish(ref FishCost);

            //Ulga Dialog and user Interaction for Chips
            OrderChips(ref ChipsCost);

            //Calculate Total Cost
            GetTotalCost(ref FishCost, ref ChipsCost, ref TotalBill);

            //End Dialog()
            EndDialog(ref TotalBill);


        }

        public static Dictionary<string, Int16> CreateFishMenu()
        {
            //Declare Fish Dictionary
            Dictionary<string, Int16> FishMenu = new Dictionary<string, Int16>()
            {
                { "Minnows", 1 },
            };

            //Add stuff to a dictionary
            FishMenu.Add("Salmon", 10);
            FishMenu.Add("Carp", 5);
            FishMenu.Add("Rainbow Trout", 8);
            FishMenu.Add("Brook Trout", 9);
            FishMenu.Add("Tuna", 4);
            FishMenu.Add("Snack Size Special", 15);

            return FishMenu;
        }

        public static Dictionary<string, Int16> CreateChipsMenu()
        {
            //Declare Fish Dictionary
            Dictionary<string, Int16> ChipsMenu = new Dictionary<string, Int16>()
            {
                { "Cheesy Ones", 3 },
            };

            //Add stuff to a dictionary
            ChipsMenu.Add("Potato", 2);
            ChipsMenu.Add("Sun Chips", 3);
            ChipsMenu.Add("Unsalted", 1);
            ChipsMenu.Add("Fish Skin", 4);
            ChipsMenu.Add("Seaweed", 2);
            ChipsMenu.Add("Snack Size Special", 15);

            return ChipsMenu;
        }

        public static void OpenDialog()
        {
            Console.WriteLine("*In a gurgly deep woman voice*" + "\n" + "Welcome to Bills Fish and Chips... My name is Ulga... What type of fish will it be?");
        }
        public static int OrderFish(ref int FishCost)
        {
            //Create Fish Menu
            Dictionary<string, Int16> FishMenu = CreateFishMenu();

            //Loop through all of the Fish types
            foreach (KeyValuePair<string, Int16> Fish in FishMenu)
            {
                Console.WriteLine("We have {0}, which cost {1} Dollar(s)", Fish.Key, Fish.Value); 
            }

            Console.WriteLine("*sigh* Please... take your time, what will it be?");

            var input = Console.ReadLine();
            try
            {
                Console.WriteLine("Good choice... *sigh* that'l be $" + FishMenu[input]);
                FishCost += FishMenu[input];
                return FishCost;
            }

            catch
            {
                Console.WriteLine("We don't have any of those...");
                OrderFish(ref FishCost);
                return 0;
            }
            
        }

        public static int OrderChips(ref int ChipsCost)
        {
            Console.WriteLine("Alright... now on to the chips... ");
            //Create Chips Menu
            Dictionary<string, Int16> ChipsMenu = CreateChipsMenu();

            //Loop through all of the Chips
            foreach (KeyValuePair<string, Int16> Chips in ChipsMenu)
            {
                Console.WriteLine("We have {0}, which cost {1} Dollar(s)", Chips.Key, Chips.Value);
            }

            Console.WriteLine("May I recommend the Fish Skin, as it is our yummy special of the day...");

            var input = Console.ReadLine();
            try
            {
                Console.WriteLine("*sigh* Very good choice, that'l be $" + ChipsMenu[input]);
                ChipsCost = ChipsMenu[input];
                return ChipsCost;

            }
            catch
            {
                Console.WriteLine("We don't have any of those...");
                OrderChips(ref ChipsCost);
                return 0;
            }
            
        }

        public static int GetTotalCost(ref int FishCost, ref int ChipsCost, ref int TotalBill)
        {
            TotalBill = FishCost + ChipsCost;
            return TotalBill;
            
        }

        public static void EndDialog(ref int TotalBill)
        {
            Console.WriteLine("We will have the right out, thanks for choosing Bills Fish and Chips... You're total is $" + TotalBill);
        }

    }
}

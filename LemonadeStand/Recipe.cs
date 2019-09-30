using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        public Recipe()
        {
            amountOfLemons = 0;
            amountOfSugarCubes = 0;
            amountOfIceCubes = 0;
            pricePerCup = .25;


        }






        public void ChangeRecipe()
        {
            DisplayRecipe();
            string input;
            do
            {
                
                Console.WriteLine("To mofify the recipe, type 'lemons', 'sugar', 'ice', 'price', or when you are ready press 'start'");
                
                Console.WriteLine();

                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "lemons":
                        Console.WriteLine("How many lemons do you want in each pitcher?");
                        ValidateInt(Console.ReadLine());
                        break;
                    case "sugar":
                        Console.WriteLine("How much sugar do you want in each pitcher?");
                        ValidateInt(Console.ReadLine());
                        break;
                    case "ice":
                        Console.WriteLine("How much Ice do you want in each cuo?");
                        ValidateInt(Console.ReadLine());
                        break;
                    case "price":
                        Console.WriteLine("What do you want to charge per cup? ($0.01 = $1.00");
                        ValidateDouble(Console.ReadLine());

                        break;
                    case "start":
                        break;

                }
                if (input != "price" && input != "lemons" && input != "sugar" && input != "ice" && input != "start")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(input + " is NOT a valid response");
                    Console.ResetColor();
                }

            }
            while (input != "price" && input != "lemons" && input != "sugar" && input != "ice" && input != "start");
            
        }

   


    
    public void DisplayRecipe()
        {
            Console.WriteLine("Current Recipe");
            Console.WriteLine();
            
            Console.WriteLine("Lemons per pitcher = " + amountOfLemons);
            Console.WriteLine("Sugar per pitcher = " + amountOfSugarCubes);
            Console.WriteLine("IceCubes per glass = " + amountOfIceCubes); // X 12 is per pitcher

            Console.WriteLine("Price per cup = " + pricePerCup);


        }





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {


        Player player;


        public Store(Player playerIn)
        {

            player = playerIn;
        }




        public void GoToStoreMenue()
        {

            Console.WriteLine("You have $" + player.wallet.money);
            Console.WriteLine();
            Console.WriteLine("What would you like to buy?");
            Console.WriteLine();
            Console.WriteLine("Cups? type 'cups'");
            Console.WriteLine("Lemons? type 'lemons'");
            Console.WriteLine("Sugar Cubes? type 'sugar'");
            Console.WriteLine("Ice Cubes? type 'ice'");


            Console.WriteLine();
            
           

            string input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "cups":
                    QuantityMenue("cups", 25, 50, 100, 2.00, 3.50, 4.25);
                    break;
                case "lemons":
                    QuantityMenue("lemons", 10, 45, 75, 2.00, 3.00, 4.00);
                    break;
                case "sugar":
                    QuantityMenue("sugar", 100, 200, 400, 3.00, 4.50, 6.00);
                    break;
                case "ice":
                    QuantityMenue("ice", 100, 250, 500, 1.75, 3.25, 5.25);
                    break;
                case "done":
                    break;
            }
        }


        public void QuantityMenue(string item, int quant1, int quant2, int quant3, double price1, double price2, double price3)
        {
            Console.WriteLine("What quantity of " + item + " do you want to buy? (enter the number");
            Console.WriteLine("Option '1' ( " + quant1 + " for $" + price1);
            Console.WriteLine("Option '2' ( " + quant2 + " for $" + price2);
            Console.WriteLine("Option '3' ( " + quant3 + " for $" + price3);
            Console.WriteLine("or type 'back' to go back to the last menue");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CanAffordItems(item, quant1, price1);
                    break;
                case "2":
                    CanAffordItems(item, quant2, price2);
                    break;
                case "3":
                    CanAffordItems(item, quant3, price3);
                    break;

                case "back":
                    // back to other menue
                    break;

            }
        }



        public void CanAffordItems(string item, int quant, double price)
        {
            bool didBuy = player.wallet.CheckWallet(price);
            if (didBuy == true)
            {
                Console.WriteLine("purchased " + quant + " " + item + " for $" + price);
                player.inventory.AddItemsToInventory(quant, item);
                
                Console.WriteLine("remaining money $" + player.wallet.money);
                player.inventory.DisplayInventory();
                
                Console.ReadLine();
                GoToStoreMenue();
            }
            else
            {
                Console.WriteLine("You dont have enough money to buy this item");
                GoToStoreMenue();
            }

        }

            






    }
}

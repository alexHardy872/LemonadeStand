using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Player
    {
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        public double businessProfits;


        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
            


        }

        public void DisplayInventory()
        {
            inventory.DisplayInventory();

        }

        public void GoToStore()
        {


        }

        public void RecipeMenue()
        {

        }

        public void StartDay()
        {

        }


        // buys things

        // makes recipee

        // holds inventory






    }
}

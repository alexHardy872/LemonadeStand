using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Item> lemons;
        public List<Item> iceCubes;
        public List<Item> cups;
        public List<Item> sugarCubes;


        public Inventory()
        {
            lemons = new List<Item> {};
           iceCubes = new List<Item> {};
            cups = new List<Item> { };
            sugarCubes = new List<Item> {};


        }

        public void DisplayInventory()
        {
            
            Console.WriteLine(" Inventory");
            Console.WriteLine(cups.Count + " Cups");
            Console.WriteLine(lemons.Count + " Lemons");
            Console.WriteLine(sugarCubes.Count + " SugarCubes");
            Console.WriteLine(iceCubes.Count + " IceCubes");
            
          
        }

        public void AddItemsToInventory( int quantity, string item)
        {

            switch (item)
            {
                case "cups":
                    for (int i = 0; i < quantity; i++)
                    {
                        Cup cup = new Cup();
                        cups.Add(cup);
                    }
                    break;
                case "lemons":
                    for (int i = 0; i < quantity; i++)
                    {
                        Lemon lemon = new Lemon();
                        lemons.Add(lemon);
                    }
                    break;
                case "sugar":
                    for (int i = 0; i < quantity; i++)
                    {
                        SugarCube sug = new SugarCube();
                        sugarCubes.Add(sug);
                    }
                    break;
                case "ice":
                    for (int i = 0; i < quantity; i++)
                    {
                        IceCube ice = new IceCube();
                        iceCubes.Add(ice);
                    }
                    break;


            }

        }

        public void AddToList()
        {

           


        }





    }
}

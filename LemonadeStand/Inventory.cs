using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Lemon> lemons;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
        public List<SugarCube> sugarCubes;


        public Inventory()
        {
            lemons = new List<Lemon> {};
           iceCubes = new List<IceCube> {};
            cups = new List<Cup> { };
            sugarCubes = new List<SugarCube> {};


        }

        public void DisplayInventory()
        {
            
            Console.WriteLine(" Inventory");
            Console.WriteLine(cups.Count + " Cups");
            Console.WriteLine(lemons.Count + " Lemons");
            Console.WriteLine(sugarCubes.Count + " SugarCubes");
            Console.WriteLine(iceCubes.Count + " IceCubes");
            Console.ReadLine();
          
        }





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {

        double likelyhoodToBuy;
        string weather;
        private List<string> names;
        public string name;



        // CONSRUCTOR
        //take in temp, weather condition, amount of ice? blah blah

        public Customer(string forcast, int temp, int name)
        {
            likelyhoodToBuy = temp / 100;
            weather = forcast;


        }


       


        // buy lemonade

        //likelyhood determined by weather, price, and random individuals








    }
}

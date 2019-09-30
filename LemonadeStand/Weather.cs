using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public string condition;
        public int temperature;
        private List<string> weatherConditions;
        public string predictedForecast;
        public Random rand;



        public Weather()
        {
            weatherConditions = new List<string> { "Snowy", "Rainy", "Overcast", "Clear" , "Sunny" };


        }



        // Determine Wheather

        // Predict forecast

        public int RandomNumber(int min, int max)
        {

            rand = new Random();
            int num = rand.Next(min, max);

            return num;
        }
        











    }

    
}

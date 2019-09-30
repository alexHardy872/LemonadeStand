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
        public string currentWeather;



        public Weather()
        {
            weatherConditions = new List<string> { "Snowy", "Rainy", "Overcast", "Clear" , "Sunny" };
            temperature =  RandomNumber(30, 100);
            currentWeather = weatherConditions[RandomNumber(0, 4)];
           
            



        }

        public string PredictForcast()
        {
            int index = weatherConditions.IndexOf(currentWeather);

            int accuracy = RandomNumber(0, 2); // determine to be correct or not
            int error = RandomNumber(0, 1); // determine to add or substract

            if (index == 0)
            {
                error = 1;
            }
            else if (index == weatherConditions.Count -1)
            {
                error = 0;
            }

            if (accuracy > 0)
            {
                return currentWeather;
            }
            else
            {
                if (error == 0)
                {
                    return weatherConditions[index + 1];
                }
                else
                {
                    return weatherConditions[index - 1];
                }
            }

          
        }

        public int PredictTemp()
        {
            int error = RandomNumber(0, 1);

            if (error == 0)
            {
                return temperature - RandomNumber(0, 10);
            }
            else
            {
                return temperature + RandomNumber(0, 10);
            }

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {

        public Weather weather;
        public List<Customer> customers;
        int dayNum;
        int crowd;
        


        public Day(int day)
        {
            dayNum = day;


        }

        public void GetWeather()
        { 
             weather = new Weather();

            Console.WriteLine("Forcasted weather is " + weather.PredictForcast() + " and " + weather.PredictTemp());
            Console.WriteLine("Actual weather is " + weather.currentWeather + " and " + weather.temperature);
            Console.ReadLine();

        }


        
        public void GetCustomers(int id)
        {
            Customer customer = new Customer(weather.currentWeather, weather.temperature , id);
            customers.Add(customer);

        }

        public void HowManyCustomers()
        {
            int startNum = GetRandomNum(60, 130);
            crowd = startNum;

        }

        public void CreateCustomers()
        {

            for (int i = 0; i < crowd; i++ )
            {
                GetCustomers(i);

            }
        }

        public int GetRandomNum(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }



        // how many customer



    }
}

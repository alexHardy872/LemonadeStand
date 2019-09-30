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
            crowd = GetRandomNum(60, 120);
            customers = new List<Customer> { };


        }

        public void GetWeather()
        { 
             weather = new Weather();

         

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

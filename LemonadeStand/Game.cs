using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    


    class Game
    {


        public Player playerOne;
        public List<Day> days;
        public Day currentDay;
        public int currentDayNum;
        //public string GameStyle;
        int seasonLength;
        


        public Game()
        {
            currentDayNum = 0;
            days = new List<Day> {};
            seasonLength = 7;
        }




        public void StartGame()
        {
            Welcome();
            CreateAllDays();
           
           
   
            CreatePlayer();

            DisplayCurrentDay();

            playerOne.DisplayInventory();

            // go to store

            TakePlayerToStore(playerOne);


           // Directory(playerOne);

            // go to store to buy more

            // make recipee

            // back to store options ect 

        }

        public void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to Lemonade Stand! Press ENTER to begin!");
            Console.ReadLine();
            Console.Clear();
        }


        public void TakePlayerToStore(Player player)
        {
            Store store = new Store(player);
            store.GoToStoreMenue();

        }
 



        public void NewDay(int dayNum)
        {
            Day day = new Day(dayNum);

            day.GetWeather(); // new weather
            day.CreateCustomers(); // new customers
            days.Add(day);
        }

        public void CreateAllDays()
        {
            for ( int i = 1; i <= seasonLength; i++)
            {
                NewDay(i);
               
            }

        }

        public void DisplayCurrentDay()
        {
            Day currentDay = days[currentDayNum];
            Console.WriteLine("Forcasted weather is " + currentDay.weather.PredictForcast() + " and " + currentDay.weather.PredictTemp());
            //Console.WriteLine("Actual weather is " + currentDay.weather.currentWeather + " and " + currentDay.weather.temperature);
            Console.WriteLine(currentDay.customers.Count + " potential customers");
            Console.ReadLine();
        }
        
     

        public void CreatePlayer()
        {
            playerOne = new Human("Player 1");

        }

        public void Directory(Player player)
        {
            Console.WriteLine(player.name + " has $" + player.wallet.money);
            Console.WriteLine("Would you like to go to the 'store' alter the 'recipe' or 'start' Day " + currentDay + "?");
            string goTo = Console.ReadLine();
           
            switch (goTo)
            {
                case "store":
                    player.GoToStore();
                    break;
                case "recipe":
                    player.RecipeMenue();
                    break;
                case "start":
                    player.StartDay();
                    break;

            }
        }











    }





}

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
        public int currentDay;
        public string GameStyle;
        


        public Game()
        {
            currentDay = 1;
            days = new List<Day> {};
        }




        public void StartGame()
        {
            Welcome();
            //GameStyleSelector();
            NewDay();
            // display forecast ect ect
            GetWeather();
            CreatePlayer();

            playerOne.DisplayInventory();

            

            Directory(playerOne);

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

 



        public void NewDay()
        {
            Day day = new Day(currentDay);
            Console.WriteLine("Day " + currentDay);
            Console.ReadLine();
            // new day
            // new wheather
            // show wheather forecast

            days.Add(day);
        }

        public void GetWeather()
        {
            Weather forcast = new Weather();
            
            Console.WriteLine("Forcasted weather is "+forcast.PredictForcast()+" and "+forcast.PredictTemp());
            Console.WriteLine("Actual weather is " + forcast.currentWeather + " and " + forcast.temperature);
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

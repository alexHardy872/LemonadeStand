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
            currentDayNum = 1;
            days = new List<Day> {};
            seasonLength = 7;
        }




        public void StartGame()
        {
            Welcome();
            CreateAllDays();
           
           
            
      
            CreatePlayer();

            playerOne.DisplayInventory();

            // go to store


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

 



        public void NewDay(int dayNum)
        {
            Day day = new Day(dayNum);
            Console.WriteLine("Day " + dayNum);
            Console.ReadLine();

            day.GetWeather(); // new weather
            //day.CreateCustomers(); // new customers
            days.Add(day);
        }

        public void CreateAllDays()
        {
            for ( int i = 1; i <= seasonLength; i++)
            {
                NewDay(i);
               
            }

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

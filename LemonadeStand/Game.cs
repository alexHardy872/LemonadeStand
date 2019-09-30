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
            CreatePlayer();

            playerOne.

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

        public void CreatePlayer()
        {
            playerOne = new Human("Player 1");

        }











    }





}

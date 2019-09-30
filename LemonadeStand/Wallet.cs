using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        public double money;



        public Wallet()
        {
            money = 20;
        }

        // update wallet with expenses

        // catch when empty


        public bool CheckWallet(double price)
        {
            if (price > money)
            {
                return false;
            }
            else
            {
                money -= price;
                return true;
            }
        }

    }
}

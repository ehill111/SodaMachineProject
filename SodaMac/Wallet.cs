using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMac
{   //Member variables have/has a/an...
    class Wallet
    {
        public string coins;
        public string card;
        public double walletBalanceOfQuarters;
        public double walletBalanceOfDimes;
        public double walletBalanceOfNickels;
        public double walletBalanceOfPennies;

        //Methods do something.
        public void KeepTrackOfCoins()
        {
            Quarter Quarters = new Quarter();
            Dime Dimes = new Dime();
            Nickle Nickles = new Nickle();
            Penny Pennies = new Penny();

            for (int index = 0; index < 12; index++)
            {

                List<Coin> Coin = new List<Coin>();
                Coin.Add("Quarters");//This error under Add occurred when I instantiated the lists.
                Console.WriteLine(index);
                walletBalanceOfQuarters = index;
            }

            for (int index = 0; index < 10; index++)
            {
                List<Coin> Coin = new List<Coin>();
                Coin.Add("Dimes");
                Console.WriteLine(index);
                walletBalanceOfDimes = index;
            }

            for (int index = 0; index < 15; index++)
            {
                List<Coin> Coin = new List<Coin>();
                Coin.Add("Nickles");
                Console.WriteLine(index);
                walletBalanceOfNickels = index;
            }

            for (int index = 0; index < 25; index++)
            {
                List<Coin> register = new List<Coin>();
                Coin.Add("Pennies");
                Console.WriteLine(index);
                walletBalanceOfPennies = index;
            }
            Console.WriteLine()


        }

    }
}

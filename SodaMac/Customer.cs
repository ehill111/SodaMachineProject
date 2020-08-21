using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMac
{   //Member variables have/has a/an...
    class Customer
    {
        public string wallet;
        public string backpack;
        public double rootBeer;
        public double cola;
        public double orange;
        public int customerSelectionOfSoda;//Why did it have to be int?


        //Contructors initialize values upon instantiation.


        //Methods do something.
        public void CustomerSelectsCoins()//Customers selects the cost of can.
        {
            double rootBeer = .60;
            int customerCoins;
            if(customerSelectionOfSoda == rootBeer)//Why did it have to be int?
            {
                customerCoins = Quarter && Quarter && Dime;
            }

            double cola = .35;
            if (customerSelectionOfSoda == cola)
            {
                customerCoins = (Quarter && Dime);
            }

            double orange = .06;
            if (customerSelectionOfSoda == orange)
            {
                customerCoins = (Nickel && Penny);
            }


        }

        public void CustomerPaysForSoda()
        {

        }

    }
}

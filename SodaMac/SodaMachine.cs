using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMac
{   //Member variables have/has a/an...
    class SodaMachine
    {
        public string register;
        public string inventory;
        public double Quarters;
        private double quarters;

        private double dimes;
        private double nickels;
        private double pennies;
        public string rootBeer;
        public string cola;
        public string orange;

        //Properties



        //Contructors initialize values upon instantiation.


        //Methods do something.
        public void DispenseCoins()
        {
            for (int index = 0; index < 21; index++)
            {
                List<double> register = new List<double>();
                register.Add(.25);
                Console.WriteLine(index);
                
            }

            
        }
       
        public void DispenseSoda()
        {
            List<string> inventory = new List<string> { "Rootbeer", "Cola", "Orange" };
        }
            //THIS IS NOT MINE!!! IT'S POINTING ME BACK TO MICROSOFT DOCUMENTATION WHERE I SAW EXAMPLES LIKE THIS.
            //denominations = new List<Coin>();
            //denominations.Add(new Coin { name = "Ten", value = 1000 });
            //denominations.Add(new Coin { name = "Five", value = 500 });
            //denominations.Add(new Coin { name = "One", value = 100 });
            //denominations.Add(new Coin { name = "Quarter", value = 25 });
            //denominations.Add(new Coin { name = "Dime", value = 10 });
            //denominations.Add(new Coin { name = "Nickel", value = 5 });
            //denominations.Add(new Coin { name = "Penny", value = 1 });

            //denominations.Sort();
            //denominations.Revers

        public void UseMachine()
        {

        }


        



        

        

                    
            
    }
}







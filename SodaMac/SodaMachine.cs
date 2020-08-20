using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
        private double balanceOfQuarters;
        public double Dimes;
        private double dimes;
        private double balanceOfDimes;
        public double Nickels;
        private double nickels;
        private double balanceOfNickels;
        public double Pennies;
        private double pennies;
        private double balanceOfPennies;
        public string rootBeer;
        public string balanceOfRootBeer;
        public string cola;
        public string balanceOfCola;
        public string orange;
        public string balanceOfOrange;

        //Properties



        //Contructors initialize values upon instantiation.


        //Methods do something.
        public void DispenseCoins()
        {
            for (int index = 0; index < 20; index++)
            {
                List<string> register = new List<string>();
                register.Add("Quarters");
                Console.WriteLine(index);
                balanceOfQuarters = index;
            }

            for (int index = 0; index < 10; index++)
            {
                List<string> register = new List<string>();
                register.Add("Dimes");
                Console.WriteLine(index);
                balanceOfDimes = index;
            }

            for (int index = 0; index < 20; index++)
            {
                List<string> register = new List<string>();
                register.Add("Nickels");
                Console.WriteLine(index);
                balanceOfNickels = index;
            }

            for (int index = 0; index < 50; index++)
            {
                List<string> register = new List<string>();
                register.Add("Pennies");
                Console.WriteLine(index);
                balanceOfPennies = index;
            }
            Console.WriteLine();
        }

        public void DispenseCans()
        {
            for (int index = 0; index < 50; index++)
            {
                List<string> register = new List<string>();
                register.Add("Cola");
                Console.WriteLine(index);
                int balanceOfCola = index;
            }

            for (int index = 0; index < 50; index++)
            {
                List<string> register = new List<string>();
                register.Add("Root Beer");
                Console.WriteLine(index);
                int balanceOfRootBeer = index;
            }

            for (int index = 0; index < 50; index++)
            {
                List<string> register = new List<string>();
                register.Add("Orange");
                Console.WriteLine(index);
                int balanceOfOrange = index;
            }
            Console.WriteLine();

        }


    }


}








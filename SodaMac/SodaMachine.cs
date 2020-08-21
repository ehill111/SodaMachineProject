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
        public double Nickles;
        private double nickles;
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
            
            Quarter Quarters = new Quarter();//Will these objects retain their data even though they're instantiated in a method and as member variables?
            Dime Dimes = new Dime();
            Nickle Nickles = new Nickle();
            Penny Pennies = new Penny();
            

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
                register.Add("Nickles");
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

            Cola Cola = new Cola();//Need to change names. Similarity to class is confusing.
            RootBeer RootBeer = new RootBeer();
            OrangeSoda Orange = new OrangeSoda();
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
                register.Add("Root Beer");//How do spaces in list names affect the system?
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








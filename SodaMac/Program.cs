using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SodaMac
{
    class Program
    {
        static void Main(string[] args)
        {
            //SodaMachine sodaMachine = new SodaMachine();
            //sodaMachine.DispenseCoins();
            //Console.ReadLine();

            Userinterface userinterface = new Userinterface();
            userinterface.SelectAndPayForSoda();
            Console.ReadLine();

           // List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            //Console.WriteLine(numbers.Count);

            //numbers.Add(20);   
            
            
        }
    }
}

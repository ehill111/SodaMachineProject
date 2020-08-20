using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SodaMac
{
    public class Userinterface
    {

        public void SelectPaymentForSoda()
        {
            List<string> coinListForPrompts = new List<string> { "Coins", "Dollar", "Debit", "Credit", };
            Console.WriteLine("Hello! Enter coin, dollar, debit, or credit payment. Push button: (1) Coins, (2) Dollar, (3) Debit, or (4) Credit.");
            Console.ReadLine();
            Console.WriteLine("Unfortunately, you are broke. Your card was declined. Choose another method of payment: (1) Coins, (2) Dollar, (3) Debit, or (4) Credit.");
            Console.ReadLine();
            Console.WriteLine("You chose to pay with . " + ".");
        }

        public void SelectFlavorForSoda()
        {
            List<string> canListForPrompts = new List<string> { "Root Beer", "Orange", "Cola" };

            Console.WriteLine("What cold soda would you like? (1) Root Beer, (2) Orange, or(3) Cola?");
            Console.ReadLine();
            Console.WriteLine("Excellent choice! You chose " + " . Don't forget your change.");
            Console.ReadLine();
        } 
        

           
            
           

        }













    }
}

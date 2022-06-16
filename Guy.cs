using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeAndBob
{
    internal class Guy
    {
        public string Name;
        public int Cash;

        //Writes a guys name and the amount of cash he has.
        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " Has " + Cash + " bucks ");
        }

        
        public int GiveCash(int amount)
        {
            // Gives cash, if the amount is less than or equal to 0 it is invalid
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says " + amount + " isn't a valid amount");
                return 0;
            }
            
            // If the amount a guy is trying to give is greater than the cash in his wallet, print that he does not have enough. 
            if(amount > Cash)
            {
                Console.WriteLine(Name + " says: " + " I don't have enough cash to give you" + amount);
                return 0;
            }

            Cash -= amount;
            return amount;
        }

         
        public void ReceiveCash(int amount)
        {
            // If the amount is less than or equal to 0, print that it is not an amount a guy will take
            if(amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + "isn't an amount I'll take");
            }
            
            //If the cash is valid, add it 
            else
            {
                Cash += amount;
            }
        }
    }
}

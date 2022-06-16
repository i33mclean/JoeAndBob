﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeAndBob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() { Name = "Joe", Cash = 50};
            Guy bob = new Guy() { Name = "Bob", Cash = 50 };


            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;

                if (int.TryParse(howMuch, out int amount))
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if(whichGuy == "Joe")
                    {
                        int cashGiven = joe.GiveCash(amount);
                        bob.ReceiveCash(cashGiven);
                    }

                    else if(whichGuy == "Bob")
                    {
                        int cashGiven  = bob.GiveCash(amount);
                        joe.ReceiveCash(cashGiven);
                    }

                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }
            }
        }
    }
}

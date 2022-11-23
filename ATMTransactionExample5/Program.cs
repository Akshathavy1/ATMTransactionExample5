using System;
using System.Text.RegularExpressions;

namespace ATMTransactionExample5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = 10000;
            int option;
            int withdraw;

            const string pattern = "[0-9]{6}";
            Regex rg = new Regex(pattern);
            Console.WriteLine("please enter your  pin :\n");
            var Oldpin = int.Parse(Console.ReadLine());
            var success = rg.IsMatch(Oldpin.ToString());
            if (!success)
            {
                Console.WriteLine("length of the password should be 6 digit ");
            }

            else if(success)
            {
                Console.WriteLine("WELCOME To ATM service......");
                Console.WriteLine("1.Check balance ");
                Console.WriteLine("2.Withdraw cash ");
                Console.WriteLine("3.change pin");
                Console.WriteLine("4.Quit");
            }
            
            Console.WriteLine("please enter your option \n:");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Your balance amount in Rs:{0}", amount);
                    break;
                case 2:
                    Console.WriteLine("please enter the amount :");
                    withdraw = int.Parse(Console.ReadLine());
                    if (withdraw % 100 != 0)
                    {
                        Console.WriteLine("please enter the amount is multiple of 100 ");
                    }
                    else if (withdraw >= 500)
                    {
                        Console.WriteLine("please enter amount more than or eqal to 500 ");
                    }
                    else if (withdraw > amount)
                    {
                        Console.WriteLine("insuffient balance");
                    }
                    else
                    {
                        amount = amount - withdraw;
                        Console.WriteLine("plase collect your cash ");
                        Console.WriteLine("your balance is: ",amount);
                        Console.WriteLine("Thank you for using ATM....");
                    }

                    break;
                case 3:
                    Console.WriteLine("please enter new pin \n :");
                    var Newpin = int.Parse(Console.ReadLine());
                    success = rg.IsMatch(Newpin.ToString());
                    if (Newpin==Oldpin)
                    {
                        Console.WriteLine("your old and new pin are same ");
                    }
                    else if (!success)
                    {
                        Console.WriteLine("enter only 6 digit  ");
                    }
                    else
                    {
                        Console.WriteLine("Accepted");
                    }
                    break;
                case 4:
                    Console.WriteLine("THANK YOU..... press any key!!!!");
                    Console.ReadKey();
                    success = false;
                    break;


            }
            Console.Read();

        }
    }
}

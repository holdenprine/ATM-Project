using System;

namespace MyATMMachine
{
    class Program
    {
        static void main(string[] args)
        {
            //sets the title of the console
            Console.Title = "ATM Machine";

            //sets text color
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("Please enter your 4-digit pin: ");
            
            string pin = RequestPIN();
            
            Console.ReadKey();
        }
    
        private static string RequestPIN()
        {
            StringBuilder sb = new StringBuilder();
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);

                if(!char.IsControl(keyInfo.keyChar))
                {
                    sb.Append(keyInfo.KeyChar);
                    Console.Write("*");
                }
            } while(keyInfo.Key != ConsoleKey.Enter);
            {
                return sb.ToString();
            }
        }
    
        public string Menu()
        {
            Console.WriteLine("Menu:\n1:Deposit\n2:Withdraw\n3:Exit\n");

            switch()
            {
                Case 1:
                    Withdraw();
                break;

                Case 2:
                    Deposit();
                break;

                Case 3:
                    if(Console.ReadLine("3"))
                    {
                        Environment.Exit(exitCode);
                    }
                break;
            }
            
            StringBuilder build = new StringBuilder();
            ConsoleKey keyInfo;

        }
        
        public string Withdraw()
        {
            int balance = 1000;
            int withdrawVal = Console.ReadLine();

            Console.WriteLine("How much would you like to withdraw?:\n");
            
            if(withdrawVal < balance)
            {
                int newBalance = balance - withdrawVal
                Console.WriteLine("Your remaining balance is: " + ToString(newBalance)); 
            }
            else
            {
                int negBalance = withdrawVal - balance
                
                string format = "-" + negBalance;
                Console.WriteLine("Your remaining balance is: " + ToString(negBalance));
            }
            
        } 
    
        public string Deposit()
        {
            
            int balance = 1000;
            
            Console.WriteLine("How much would you like to deposit?:\n");
            int depositVal = Console.ReadLine();
            
            int addBalance = depositVal + balance;

            Console.WriteLine("Your new balance is: " + addBalance);

        }
    
    }
}
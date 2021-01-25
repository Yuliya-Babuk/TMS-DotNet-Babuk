using System;

namespace ATM_Managment
{
    public class ATM
    {
        public delegate void Action(decimal balance, string action);
        public event Action BalanceHandler;

        private decimal _balance = 0;

        public void AddFunds(decimal _count)
        {
            _balance += _count;
            BalanceHandler?.Invoke(_balance, "deposite");
        }
        public void WithdrawFunds(decimal _count)
        {
            if (_count > _balance)
            {
                Console.WriteLine("You do not have enough funds to withdraw");
            }
            else
            {
                _balance -= _count;
                BalanceHandler?.Invoke(_balance, "withdrawal");
            }
        }
        public void ShowBalance()
        {
            BalanceHandler?.Invoke(_balance, "\"Show balance\"");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            bool exit = false;
            while (!exit)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hello! \nPlease select an operation:\nA - to add funds, \nW - to withdraw funds, \nB - to show a balance, \nE - to exit\n");
                Console.ResetColor();
                atm.BalanceHandler += ActionInfo;

                switch (Console.ReadLine().ToUpper())
                {
                    case "A":
                        Console.Write("\nEnter an amount:   ");
                        Decimal.TryParse(Console.ReadLine(), out decimal amount);
                        atm.AddFunds(amount);
                        break;
                    case "W":
                        Console.Write("\nEnter an amount:   ");
                        Decimal.TryParse(Console.ReadLine(), out decimal amount1);
                        atm.WithdrawFunds(amount1);
                        break;
                    case "B":
                        atm.ShowBalance();
                        break;
                    case "E":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Enter correct operation:");
                        break;
                }
                static void ActionInfo(decimal balance, string action)
                {
                    Console.WriteLine($"You made a {action} transaction. Your balance is {balance} BYN");
                }
                atm.BalanceHandler -= ActionInfo;
            }
        }
    }
}

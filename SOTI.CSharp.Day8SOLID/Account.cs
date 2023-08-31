using System;

namespace SOTI.CSharp.Day8SOLID
{
    public abstract class Account
    {
        public Account(int accountNo, string accountholderName)
        {
            AccountNo = accountNo;
            AccountholderName = accountholderName;
        }

        public int AccountNo { get; set; }
        public string AccountholderName { get; set; }
        public double MinBalance { get; set; }

        public abstract void CreateAccount(double minBalance);
        public abstract void DisplayAccountDetails();

    }

    public class SavingsAccount : Account
    {
        public SavingsAccount(int accountNo, string accountholderName) : base(accountNo, accountholderName)
        {
        }

        public override void CreateAccount(double minBalance)
        {
            if (minBalance > 5000)
            {
                MinBalance = minBalance;
            }
            else
            {
                throw new Exception("Minimum Balance should be 5000");
            }
        }

        public override void DisplayAccountDetails()
        {
            Console.WriteLine($"Account No :{AccountNo}\nName :{AccountholderName}\nBalance :{MinBalance}");
        }
    }

    public class CurrentAccount : Account
    {
        public CurrentAccount(int accountNo, string accountholderName) : base(accountNo, accountholderName)
        {
        }

        public override void CreateAccount(double minBalance)
        {
            if (minBalance > 10000)
            {
                MinBalance = minBalance;
            }
            else
            {
                throw new Exception("Minimum Balance should be 10000");
            }
        }

        public override void DisplayAccountDetails()
        {
            Console.WriteLine($"Account No :{AccountNo}\nName :{AccountholderName}\nBalance :{MinBalance}");
        }       
    }
}

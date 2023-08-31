using System;

namespace SOTI.CSharp.Day6
{
    internal class PredefinedDelegates
    {
        public void GetCustomer(int customerId, string customerName, long mobileNo)
        {
            Console.WriteLine($"Customer Id :{customerId}\tCustomer Name :{customerName}\tMobile No :{mobileNo}");
        }

        public bool ValidateMobileNo(string mobileNo)
        {
            if (mobileNo.Length == 10)
                return true;
            else
                return false;
        }

        public void Initialize()
        {
            Action<int, string, long> customer = GetCustomer;
            Func<string, bool> validate = ValidateMobileNo;
            //Predicate<>

            //Calling Action Delegate
            customer(1001, "Praveen", 789456123);

            //Calling Func Delegate
            var result = validate("7894561230");
            if (result)
                Console.WriteLine("Valid Mobile No");
            else
                Console.WriteLine("Invalid Mobile No");

            //Anonymous Method using Lambda Expression
            Func<int, int, int> addNumber = (int a, int b) =>
            {
                return a + b;
            };
            Console.WriteLine($"Add :{addNumber(50, 60)}");
        }

        static void Main1(string[] args)
        {
            PredefinedDelegates obj = new PredefinedDelegates();
            obj.Initialize();
        }
    }
}

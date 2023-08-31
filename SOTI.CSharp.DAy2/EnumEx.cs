using System;
using static System.Console;

namespace SOTI.CSharp.DAy2
{
    public enum CardType
    {
        Silver = 1001,
        Diamond,
        Platinum
    }

    public class Customer
    {
        public int customerId;
        public string customerName;
        // public string cardType;
        public CardType cardType;

        public Customer()
        {
            customerId = 10;
            customerName = "ABC";
            cardType = CardType.Silver;
        }

        public Customer(int customerId, string customerName, CardType cardType)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.cardType = cardType;
        }

        public void DisplayCustomer()
        {
            WriteLine($"Customer Id :{customerId}\nCustomer Name :{customerName}\nCard Type :{cardType}");
        }
    }
}

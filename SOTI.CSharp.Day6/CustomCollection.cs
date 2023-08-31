using System;

namespace SOTI.CSharp.Day6
{
    internal class ContactDetails<T>
    {
        public T[] Contacts { get; set; }
        public int Index { get; set; }
        public int Size { get; set; }        

        public ContactDetails(int size)
        {
            Size = size;
            Contacts = new T[size];
            Index = 0;
        }

        public void AddContact(T mobileNo)
        {
            if (Index < Size)
            {
                Contacts[Index] = mobileNo;
            }
            Index++;
        }

        public T GetContactDetails(int number)
        {
            return Contacts[number];
        }
    }

    class ExecuteClass
    { 
        static void Main(string[] args)
        {
            ContactDetails<int> mobileContact = new ContactDetails<int>(3);
            mobileContact.AddContact(7777777);
            mobileContact.AddContact(66666666);
            mobileContact.AddContact(88888888);

            ContactDetails<string> emailContact = new ContactDetails<string>(3);
            emailContact.AddContact("77777@gmail.com");
            emailContact.AddContact("66666@gmail.com");
            emailContact.AddContact("88888@gmail.com");

            Random random = new Random();
            int luckyNo = random.Next(0, 3);//0 1 2
            var mobileNo = mobileContact.GetContactDetails(luckyNo);
            var emailId = emailContact.GetContactDetails(luckyNo);
            Console.WriteLine($"Lucky Mobile No :{mobileNo}");
            Console.WriteLine($"Lucky Email Id :{emailId}");
        }
    }
}

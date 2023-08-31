using System;

namespace SOTI.CSharp.Day4.Exercises
{
    public class Employee
    {
        private static int nextEmployeeNumber;
        private short numberOfDependents;
        private string[] dependents;

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short NumberOfDependents { get => numberOfDependents; set => numberOfDependents = value; }

        static Employee()
        {
            nextEmployeeNumber = 1000;
        }

        public Employee()
        {
            EmployeeId = ++nextEmployeeNumber;
            //dependents = new string[NumberOfDependents];
        }

        public Employee(string employeeName, bool gender, DateTime dateOfBirth) : this()
        {
            EmployeeName = employeeName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
        }

        public Employee(string employeeName, bool gender, DateTime dateOfBirth, short numberOfDependents) : this(employeeName, gender, dateOfBirth)
        {
            NumberOfDependents = (short)(numberOfDependents <= 0 ? 0 : numberOfDependents >= 3 ? 3 : numberOfDependents);
            dependents = new string[NumberOfDependents];
        }

        public int AddDependent(string dependentName)
        {
            if (!string.IsNullOrEmpty(dependents[0]) || !string.IsNullOrEmpty(dependents[1]) || !string.IsNullOrEmpty(dependents[2]))
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < NumberOfDependents; i++)
                {
                    dependents[i] = dependentName;
                }
            }
            return dependents.Length;
        }

        public bool UpdateDependent(string dependentName, int dependentId)
        {
            if (NumberOfDependents == 0)
                return false;
            else
            {
                if (dependentId < dependents.Length && dependentId >= 0)
                {
                    dependents[dependentId] = dependentName;
                    return true;
                }
            }
            return false;
        }

        public void Display()
        {
            Console.WriteLine($"Employee Name :{EmployeeName}\n");
            for (int i = 0; i < dependents.Length; i++)
            {
                Console.WriteLine($"Dependent {i + 1} is {dependents[i]}");
            }
        }

        static void Main(string[] args)
        {
            Employee emp = new Employee("Pradeep", true, new DateTime(1998, 12, 22), 4);
            do
            {
                Console.WriteLine("1. Add\n2. Update\n3. Display\n4. Exit");
                byte choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Dependent Name :");
                        emp.AddDependent(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Enter the Dependent Id :(0 or 1 or 2)");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter the Update Name :");
                        emp.UpdateDependent(Console.ReadLine(), id);
                        break;
                    case 3:
                        emp.Display();
                        break;
                    case 4:
                        return;
                }
            } while (true);
        }
    }
}

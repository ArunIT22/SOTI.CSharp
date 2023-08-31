using System;

namespace SOTI.CSharp.Day8SOLID
{
    public interface IEmployee
    {
        int EmployeeId { get; set; }
        string EmployeeName { get; set; }
        decimal CalculateSalary(int noOfDaysWorked);
    }

    public interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);

        string TestMethod();
    }

    public abstract class Employee_OCP : IEmployee, IEmployeeBonus
    {
        public Employee_OCP(int employeeId, string employeeName)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public abstract decimal CalculateSalary(int noOfDaysWorked);
        public abstract decimal CalculateBonus(decimal salary);

        public string TestMethod()
        {
            throw new NotImplementedException();
        }
    }

    public class PermanentEmployee : Employee_OCP
    {
        public PermanentEmployee(int employeeId, string employeeName) : base(employeeId, employeeName)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.1M;
        }

        public override decimal CalculateSalary(int noOfDaysWorked)
        {
            return 10000 * noOfDaysWorked;
        }
    }

    public class TemporaryEmployee : Employee_OCP
    {
        public TemporaryEmployee(int employeeId, string employeeName) : base(employeeId, employeeName)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.08M;
        }

        public override decimal CalculateSalary(int noOfDaysWorked)
        {
            return 5000 * noOfDaysWorked;
        }
    }

    public class ContractEmployee : IEmployee
    {
        public ContractEmployee(int employeeId, string employeeName)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public decimal CalculateSalary(int noOfDaysWorked)
        {
            return 3000 * noOfDaysWorked;
        }
    }

    public class ExecuteClass
    {
        static void Main(string[] args)
        {
            // IEmployee emp = new PermanentEmployee(1001, "Asdasd");

            Employee_OCP obj = new PermanentEmployee(1001, "Arjun");
            var permRes = obj.CalculateSalary(25);
            obj.CalculateBonus(500000);
            Console.WriteLine($"Employee Id :{obj.EmployeeId}\tName :{obj.EmployeeName}\tSalary :{permRes}");

            IEmployee obj2 = new TemporaryEmployee(1002, "Babu");
            var tempRes = obj2.CalculateSalary(25);
            //var tempRes = obj2.CalculateBonus(500000);
            Console.WriteLine($"Employee Id :{obj2.EmployeeId}\tName :{obj2.EmployeeName}\tSalary :{tempRes}");

            IEmployee obj3 = new ContractEmployee(1003, "Contract");
            var conRes = obj3.CalculateSalary(20);
            Console.WriteLine($"Employee Id :{obj3.EmployeeId}\tName :{obj3.EmployeeName}\tSalary :{conRes}");
        }
    }
}

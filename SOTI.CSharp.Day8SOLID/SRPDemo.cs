using System;

namespace SOTI.CSharp.Day8SOLID
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string MobileNo { get; set; }

        public void GetEmployee()
        {
            try
            {
                Console.WriteLine("Enter Employee Id");
                EmployeeId= int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name :");
                EmployeeName = Console.ReadLine();
                Console.WriteLine("Enter Mobile No :");
                MobileNo = Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error :{ex.Message}");   
                ErrorClass.ErrorLog(ex);
            }
        }

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.GetEmployee();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day9
{
    public sealed class ExceptionHandler
    {
        private ExceptionHandler() { }

        public static Lazy<ExceptionHandler> _handler = new Lazy<ExceptionHandler>(() => new ExceptionHandler());

        public static ExceptionHandler GetInstance
        {
            get
            {
                return _handler.Value;
            }
        }

        public void ErrorLog(Exception ex)
        {
            using (FileStream fs = new FileStream(@"D:\SOTI\ErrorLog.txt", FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"Exception occurred on {DateTime.Now}");
                    sb.AppendLine($"Message :{ex.Message}");
                    sb.AppendLine($"Stack Trace :{ex.StackTrace}");

                    sw.WriteLine(sb.ToString());
                    sw.Flush();
                }
            }
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void GetEmployee()
        {
            Console.WriteLine("Enter Id :");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            ExceptionHandler errorHandler = ExceptionHandler.GetInstance;
            try
            {
                emp.GetEmployee();
            }
            catch (Exception ex)
            {
                errorHandler.ErrorLog(ex);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day8SOLID
{
    public class ErrorClass
    {
        public static void ErrorLog(Exception ex)
        {
            string error = $"Error occurred on {DateTime.Now}\nError Message :{ex.Message}\nStack Trace :{ex.StackTrace}";
            Console.WriteLine(error);
            using(FileStream fs=new FileStream(@"G:\SOTI\ErrorLog.txt", FileMode.Append))
            {
                StreamWriter sw=new StreamWriter(fs);
                sw.WriteLine(error);
                sw.Flush();
            }
        }
    }
}

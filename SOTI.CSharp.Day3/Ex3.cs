using static System.Console;

namespace SOTI.CSharp.Day3
{
    internal class UserProgramCode
    {
        public static string NextString(string input1)
        {
            int next;
            string output = string.Empty;
            for (int i = 0; i < input1.Length; i++)
            {
                if ((input1[i] >= 97 && input1[i] <= 122) || (input1[i] >= 65 && input1[i] <= 90))
                {
                    if (input1[i] == 122 || input1[i] == 90)
                    {
                        next = input1[i] - 25;
                    }
                    else
                    {
                        next = input1[i] + 1;
                    }
                    char c = (char)next;
                    output += c.ToString();
                }
                else
                {
                    return "Invalid Input";
                }
            }
            return output;
        }

        static void Main1(string[] args)
        {
            Write("Enter a String :");
            string check = ReadLine();
            WriteLine(NextString(check));
        }
    }
}

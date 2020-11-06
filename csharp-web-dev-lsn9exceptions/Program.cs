using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if(y == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else 
            {
                return x / y;
            }

        }

        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            int fileScore = 0;
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException();
                
            }
            else if (fileName.EndsWith(".cs"))
            {
                fileScore += 1;
                return fileScore;
            } 
            else
            {
                return fileScore;
            }
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            Console.WriteLine("Enter first integer: ");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer: ");
            double y = Double.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(Divide(x, y));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Cannot divide by 0");
            }


            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    Console.WriteLine(student.Key + " File Score: " + CheckFileExtension(student.Value));
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(student.Key + " File name cannot be empty");
                }
                
            }
            
            


        }
    }
}

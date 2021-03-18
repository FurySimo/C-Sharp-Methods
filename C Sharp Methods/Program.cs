using System;

namespace C_Sharp_Methods
{
    class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed.");
        }
        static void Main(string[] args)
        {
           
            {
                MyMethod();
                MyMethod();
                MyMethod();
            }
        }
    }
}

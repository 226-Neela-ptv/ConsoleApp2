using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class car
    {
        string color = "red";
        static void Main(string[] args)
        {
            color myObj = new car();
            Console.WriteLine(myObj.color);
        }
    }
}
          

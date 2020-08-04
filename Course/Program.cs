using System;
using System.Collections.Generic;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(200, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(200, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(200, 8, 15, 13, 5, 58);
            Console.WriteLine(d1);
            Console.WriteLine(d1.Kind);
            Console.WriteLine(d1.ToLocalTime());
            Console.WriteLine(d1.ToUniversalTime());
        }
    }
}


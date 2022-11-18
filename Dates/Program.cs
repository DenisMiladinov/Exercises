using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DateDifferenceCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string date1str = Console.ReadLine();
            string date2str = Console.ReadLine();

            Console.WriteLine(DateCounter.CalculateDifference(date1str, date2str));
        }
    }

    public class DateCounter
    {
        public static int CalculateDifference(string date1str, string date2str)
        {
            DateTime date1 = DateTime.ParseExact(date1str, "yyyy MM dd", null);
            DateTime date2 = DateTime.ParseExact(date2str, "yyyy MM dd", null);
            return Math.Abs((date1 - date2).Days);
        }
    }
}

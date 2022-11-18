using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "Golf";
            car.Year = 2005;

            Console.WriteLine($"Make - {car.Make}\nModel - {car.Model}\nYear - {car.Year}");
        }
    }
   
}

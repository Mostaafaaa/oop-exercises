using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    //Exercise 19: Create a Bus class with attributes route_number, driver_name, and capacity. Add a method show_info().

    internal class Bus
    {
        public string RouteNumber { get; set; }
        public string DriverName { get; set; }
        public int Capacity { get; set; }
        public Bus(string routeNumber, string driverName, int capacity)
        {
            RouteNumber = routeNumber;
            DriverName = driverName;
            Capacity = capacity;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Bus Route: {RouteNumber}, Driver Name: {DriverName}, Capacity: {Capacity} passengers");

        }
    }
}

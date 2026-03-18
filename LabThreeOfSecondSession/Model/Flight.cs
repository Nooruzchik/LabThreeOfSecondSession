using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThreeOfSecondSession.Model
{
    internal class Flight
    {
        public string DepartmentPoint { get; set; }
        public string Destination { get; set; }
        private int flightTime;

        public int FlightTime
        {
            get{return flightTime;}
            set 
            {
                if (value <= 0)
                    throw new Exception("Время полета должна быть положительной");
                flightTime = value;
            }

        }

        public Flight(string departmentPoint, string destination,int flightTime)
        {
            DepartmentPoint = departmentPoint;
            Destination = destination;
            FlightTime = flightTime;
        }

        public Flight()
        {
        }
    }
}

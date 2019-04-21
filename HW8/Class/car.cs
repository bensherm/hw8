using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW8.Enum;
using HW8.Interface;

namespace HW8.Class
{
    public class car : Vehicle
    {
        public int year;
        public string make;
        public string model;
        public colors Colors; 

        public car()
        {
            Mileage = 0;
            LastServiceMiles = 0;
        }

        public car(int theyear, string theMake, string theModel)
        {
            year = theyear;
            make = theMake;
            model = theModel;
        }

        public car(int difYear, String difMake, string difModel, colors difColor)
        {
            year = difYear;
            make = difMake;
            model = difModel;
            Colors = difColor;
        }
        
        
    }
}

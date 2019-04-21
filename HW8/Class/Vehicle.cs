using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW8.Interface;

namespace HW8.Class
{
    public class Vehicle : Ivehicles
    {
       private string _vin;
        private int _mileage;
        private DateTime _LastServiceDate;
        private int _LastServicedMileage;

        public Vehicle()
        {
            _vin = (Guid.NewGuid().ToString());
            Random Rnd = new Random();
            _mileage = Rnd.Next(1, 1000000);

            _LastServiceDate = DateTime.Now;

            Random _LastServicedMileage = new Random();
            _mileage = _LastServicedMileage.Next(1, 100000);
        }

            public string CarVin
        {
            get
            {
                return _vin;
            }
            set
            {
                _vin = value;
            }
            
        }
        public int Mileage
        {
            get
            {
                return _mileage;
            }
            set
            {
                _mileage = value;
            }
        }

            public DateTime LastServiceDate
        {
            get
            {
                return _LastServiceDate;
            }
            set
            {
                _LastServiceDate = value;
            }
        }
            public int LastServiceMiles
        {
            get
            {
                return _LastServicedMileage;
            }
            set
            {
                _LastServicedMileage = value;
            }
        }
        
     
        public void TuneUp()
        {

            if (Mileage - LastServiceMiles >= 30000)

            {
                LastServiceMiles = Mileage;
                LastServiceDate = LastServiceDate.AddMonths(2);
                Console.WriteLine($" \t Last tuned up at {Mileage} on {LastServiceDate}");

            }
            else if (Mileage >= 100000)
            {
                RebuildEngine();
            }
        }
        public void RebuildEngine()
             {
                Mileage = 0;
                LastServiceMiles = 0;
                Console.WriteLine($"\t Engine Rebuilt on {LastServiceDate}");

                
             }

        


    }
  }
  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_02
{
    class Program
    {
        static void Main(string[] args)
        {

            taxi taxi1 = new taxi();

            taxi1.Drivername = "Yadi";
            taxi1.OnDuty = true;
            taxi1.NumPassenger = 10;


            taxi1.TaxiInfo();
            taxi1.dropofpassenger();
            taxi1.pickuppassenger();

            Console.ReadKey();
        }
    }
}
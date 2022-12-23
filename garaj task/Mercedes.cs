using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mercedes : Start,Drive,IAirConditioner
    {
        public override void StartMethod()
        {
            Console.WriteLine("Mashin ishe salindi");
        }

        public virtual void DrivingMethod()
        {

            Console.WriteLine("Mashin hereket edir");
        }
        public virtual void AirConditioner()
        {
            Console.WriteLine("Kondinsioner ishleyir");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vaz_2107 : Start,Drive
    {
        public override void StartMethod()
        {
            Console.WriteLine("Mashin ishe salindi");
        }
        public virtual void DrivingMethod()
        {
            Console.WriteLine("Mashin hereket edir");
        }
    }
}

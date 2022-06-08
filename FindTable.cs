using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class FindTable
    {
        public void Table()
        {
            int n, i, t = 0;

            Console.WriteLine("enter number");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= 10; i++)
            {
                t = n * i;
                Console.WriteLine("{0}x{1}={2}", n, i, t);
            }
          

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class FindCube
    {
        public void cube()
        {
            int i, num;

            Console.WriteLine("enter number of terms");

            num = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= num; i++)
            {
                Console.WriteLine("Number is {0} and cube of the number is{1} is{2}",i,i,i*i*i);
            }

        }
    }
}

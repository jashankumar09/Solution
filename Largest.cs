using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Largest
    {
        public void LargestNo()
        {
            int num1, num2, num3;


            Console.Write("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 > num2 && num1 > num3)
            {
                Console.Write("The largest number is"+num1);


            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.Write("The largest number is"+num2);
            }
            else
                Console.Write("The largest number is"+num3);
        }
    }
}



    


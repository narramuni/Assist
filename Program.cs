using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        static void doApp()
        {
            int iint = 24;
            char ichar = 'A';
            bool ibool = true;
            short ishort = 12;   
           
            double idouble = 3.14159;

            int res = iint + 12;
            Console.WriteLine("iint:" + iint);


            char iChar = (char)(ichar + 1);
            Console.WriteLine("iChar:" + iChar);
            bool isFalse = !ibool;
            Console.WriteLine("isFalse:" + isFalse);
            double jdouble = Math.Sqrt(idouble);
            Console.WriteLine("squareRoot of idouble :" + jdouble);

            if (iint == 24 && idouble > 0  )
            {
                Console.WriteLine("This expression is  True"  );
            }
            if (ibool = true  || iChar == 'A')
            {
                Console.WriteLine("This expression is  True");

            }
            Console.ReadLine();
        }
    }
}

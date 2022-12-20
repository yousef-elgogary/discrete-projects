using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discrete_math_project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s, e ;
            Console.WriteLine("Enter the first number");
            s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the last number");
            e = int.Parse(Console.ReadLine());
            for (int n = s; n <= e; n++) 
            {
                if (n < 2)
                {
                    continue;
                }
                int n2;
                for ( n2 = 2; n2 < n; n2++)
                {
                    if (n % n2 == 0)
                    {
                       break ;
                    }
                        
                }
                if (n == n2)
                {
                    Console.WriteLine("\t" + n);
                }
            }
            
            Console.ReadKey();

        }
    }
}

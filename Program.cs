using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[5] { 3, 7, 9, -2, 1 };

            int min = int.MaxValue;

            for(int i = 0; i < v.Length; i++)
            {
                if(v[i] < min)
                {
                    min = v[i];
                }
            }

            Console.Write(min);

            Console.ReadKey();
        }
    }
}

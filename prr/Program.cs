using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prr
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random ran = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
               array[i]=ran.Next(-10,10);
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(Find(array));
            Console.ReadKey();
        }
        static int Find(int[] ints)
        {
            int count = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < 0)
                {
                    count++;
                }
            }
            return count;           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int[] marks = new int[] { 61, 67, 100, 45, 97 };

            
                int Highestmark = marks.Max();
               
                Console.WriteLine(Highestmark);
                Console.ReadKey();

            
        }
    }
}

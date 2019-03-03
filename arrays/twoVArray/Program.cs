using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using twoArrayLib;



namespace twoVArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Arrayoftwo arr = new Arrayoftwo(2, 0,6);
          
            Console.WriteLine(arr.ToString());
            Console.WriteLine(arr.Sum);
            Console.WriteLine(arr.SumMax);
            Console.WriteLine(arr.Max);
            Console.WriteLine(arr.Min);
            Console.ReadKey();
        }
    }

}

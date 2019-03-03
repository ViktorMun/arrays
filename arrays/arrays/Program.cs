using System;
using ArraysLib;
using System.Collections.Generic;

namespace ArrayClass
    {
  

    class Program
    {
        static void Main(string[] args)
        {
          
            MyArray a = new MyArray(10, 2, 2);
            Dictionary<int, int> arrayCount = new Dictionary<int, int> { { a.Sum, 1 }, { a.Max, 3 }, { a.Multi, 4 } };
           
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.Sum);
           foreach (var item in a.Inverse)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(a.Max);
            Console.WriteLine(a.Multi);
            Console.WriteLine(arrayCount.Count);
            Console.ReadKey();
        }
    }


}
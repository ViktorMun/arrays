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
                   
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.Sum);
            Console.WriteLine(a.Inverse);
            Console.WriteLine(a.Max);
            Console.WriteLine(a.Multi);
            Console.ReadKey();
        }
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace twoArrayLib
{
    public class Arrayoftwo
    {

        public int[,] arr;
        public void WriteText()
        {

            try
            {

                string[] text = new string[arr.Length];
                int z = 0;
                for (int i = 0; i < arr.GetLength(0); i++)

                {

                    for (int j = 0; j < arr.GetLength(1); j++)
                        text[z] = Convert.ToString(arr[i, j]);
                    z++;
                }


                File.WriteAllLines(@"C:\1.txt", text);
            }

            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

        }





        public string ReadText()
        {
            try
            {
                string data = File.ReadAllText(@"C:\1.txt");
                return data;
            }
            catch (Exception exc)
            {
              return exc.Message;
            }
        }

      

        public Arrayoftwo(int n, int min, int max)
        {
            arr = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    arr[i, j] = rnd.Next(min, max);
        }

        public string ToString()
        {
            string s = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    s += arr[i, j] + " ";
                s += "\n"; 

            }
            return s;
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    { sum += arr[i, j]; }
                }
                return sum;
            }
        }
        public int SumMax 
        {
            get
            { int max = 2;
                int sum = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                   if(arr[i,j]>max) { sum += arr[i, j]; }
                }
                return sum;
            }
        }


        public int Max
        {
            get
            {
                int max = arr[0, 0];
                for (int i = 0; i < arr.GetLength(0); i++)
                    for (int j = 0; j < arr.GetLength(1); j++)
                        if (arr[i, j] > max) max = arr[i, j];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = arr[0, 0];
              
                for (int i = 0; i < arr.GetLength(0); i++)
                    for (int j = 0; j < arr.GetLength(1); j++)
                        if (arr[i, j] < min) min = arr[i, j];
                return min;
            }
        }
      

    }
}

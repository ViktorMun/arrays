using System;

namespace ArraysLib
{
    public class MyArray
    {
        

        int[] a;
        int n = 2;
        public MyArray(int total, int begin, int interv)
        {
            a = new int[total];

            for (int i = 0; i < total; i++)
                a[i] = i * interv;
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 1; i < a.Length; i++)
                { sum += a[i]; }
                return sum;
            }
        }

        public int[] Inverse
        {
            get
            {
                int[] inverse = new int[a.Length];
                for (int i = 0; i < a.Length; i++)
                    inverse[i] -= a[i];
                return inverse;
            }
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Multi
        {
            get
            {
                int multi = 0;
                for (int i = 1; i < a.Length; i++)
                    multi = multi + (a[i] * n);
                return multi;
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
}

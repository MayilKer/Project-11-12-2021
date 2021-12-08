using System;
using System.Collections.Generic;
using System.Text;

namespace Project_11._12._2021
{
    class ArraySum
    {
        public int[] Arr;
        public int value;
        public int minus;
        public int sum;
        public void SumArr()
        {
            
            for (int i = 0; i < Arr.Length; i++)
            {


                bool th = 100 <= Arr[i] && Arr[i] <= 999;
                if (th)
                {
                    value += Arr[i];
                }
                else
                {
                    sum += Arr[i];

                }


            }
            minus = value - sum;
            Console.WriteLine("3 reqemlilerin cemi - " + value);
            Console.WriteLine("qalanlarin cemi - " + sum);
            Console.WriteLine("subtraction - " + minus);

        }
    }
}

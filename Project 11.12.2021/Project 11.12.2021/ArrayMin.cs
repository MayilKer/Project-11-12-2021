using System;
using System.Collections.Generic;
using System.Text;

namespace Project_11._12._2021
{
    class ArrayMin
    {
       public int[] Arr1;
        public void Min()
        {
            int min = Arr1[0];
            int index = 0;
            for (int i = 1; i < Arr1.Length; i++)
            {
                if (min > Arr1[i] )
                {
                    min = Arr1[i];
                    index = i;
                }
                
                
            }
            Console.WriteLine(min + " index is " + index);
        }
    }
}

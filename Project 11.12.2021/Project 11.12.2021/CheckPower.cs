using System;
using System.Collections.Generic;
using System.Text;

namespace Project_11._12._2021
{
    class CheckPower
    {
        public double Check;
        bool res = false;

        public void Checkpower2()
        {
            for (int i = 0; Check > 1; i++)
            {
                Check /= 2;
                if (Check == 1)
                {
                    res = true;

                }
            }
            Console.WriteLine(res);
        }
    }
}

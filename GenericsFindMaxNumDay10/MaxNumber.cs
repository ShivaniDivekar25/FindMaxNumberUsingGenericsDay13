﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFindMaxNumDay10
{
    internal class MaxNumber        //Creating class
    {
        public static void maxNumber()          //Creating method to find maximum with CompareTo method
        {
            int a = 45;
            int b = 60;
            int c = 20;
            if ((a.CompareTo(b) > 0) && (a.CompareTo(c) > 0))
            {
                Console.WriteLine("The maximum number is:" + a);
            }
            else if ((b.CompareTo(a) > 0) && (b.CompareTo(c) > 0))
            {
                Console.WriteLine("The maximum number is: " + b);
            }
            else
            {
                Console.WriteLine("The maximum number is : " + c);
            }
        }
    }
}
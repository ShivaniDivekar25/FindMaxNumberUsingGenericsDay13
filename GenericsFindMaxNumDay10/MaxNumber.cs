using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFindMaxNumDay10
{
    internal class FindMax<T> where T : IComparable
    {

        //Creating class

        public T first, second, third;
        public T[] value;
        public FindMax(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        //UC4
        public FindMax(T[] value)
        {
            this.value = value;
        }
    
        /* public static void maxNumber()          //Creating method to find maximum integer number using CompareTo method
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
         public static void maxNumber1()         //Creating method to find maximum float number using CompareTo method
         {
             float a = 11.34f;
             float b = 45.96f;
             float c = 75.74f;
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
         public static void maxNumber2()         //Creating method to find maximum for string using ComapreTo method
         {
             string a = "Apple";
             string b = "Banana";
             string c = "Pear";
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
         }*/
        // Refactor -1 for UC3
        public static T GenericMaxNumber(T first, T second, T third)          //Creating method to find maximum  by using Generic method
        {

            if ((first.CompareTo(second) > 0) && (first.CompareTo(third) > 0))
            {
                return first;
            }
            else if ((second.CompareTo(first) > 0) && (second.CompareTo(third) > 0))
            {
                return second;
            }
            else
            {
                return third;
            }
        }
        // Refactor -2 for UC3
        public void TestMaximum()
        {
            T res = GenericMaxNumber(first, second, third);
            Console.WriteLine("Max:" + res);
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is :" + max);

        }
    }
}

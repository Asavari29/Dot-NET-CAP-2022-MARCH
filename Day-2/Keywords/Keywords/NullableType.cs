﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Keywords
{
    internal class NullableType
    {
        static void Main9(string[] args)
        {
            //null
            //Nullable<int> i = null;
            //int ?k = null;

            //int samplevalue = int.Parse("3");
            //Console.WriteLine(samplevalue);
            //int result;
            //bool sample = int.TryParse("asd",out result);
            //Console.WriteLine(result);
            //Console.WriteLine(sample);

            //create a program to handle if user enter any value apart from int
            //you should show error that please enter correct integer value
            Console.WriteLine("enter some value");
            string sampleValue=Console.ReadLine();

            int result;
            bool IsIntValue = int.TryParse(sampleValue, out result);
            if (IsIntValue)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Enter the value in integer format");
            }
        }
    }
}

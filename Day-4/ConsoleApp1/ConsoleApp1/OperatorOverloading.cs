﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Calculator
    {
        //fields
        public int number1,number2;

        public Calculator()
        {

        }
        public Calculator(int num1,int num2)
        {
            number1 = num1;
            number2 = num2;
        }

        //operator overloading  with +
        // <return type> operator -keyword <operator>(<parameters>)
        public static Calculator operator +(Calculator c1, Calculator c2)
        {
            Calculator c3 = new Calculator();
            c3.number1 = c1.number1 + c2.number1;
            c3.number2 = c1.number2 + c2.number2;
            return c3;
        }
        public void Print()
        {
            Console.WriteLine("Number 1=" + number1);
            Console.WriteLine("Number 2=" + number2);
        }

    }
    internal class OperatorOverloading
    {
        static void Main3(string[] args)
        {
            int Number1,Number2;
            Console.WriteLine("Enter two numbers");
            Number1=Convert.ToInt32(Console.ReadLine());
            Number2 = Convert.ToInt32(Console.ReadLine());

            Calculator calc1=new Calculator(Number1, Number2);
            Calculator calc2=new Calculator(Number1, Number2);
            Calculator calc3 = new Calculator();
            calc3 = calc1 + calc2;
            calc3.Print();
        }
    }
}

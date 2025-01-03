﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_91
{
    internal class Ex091
    {
        private delegate void RunCalc(int a, int b);

        private static void Sum(int number1, int number2)
        {
            Console.WriteLine("SUM : {0}", number1+ number2);
        }

        private static void Multiply(int number1, int number2)
        {
            Console.WriteLine("MULTI : {0}", number1 * number2);
        }

        private static void Divide(int number1, int number2)
        {
            Console.WriteLine("DIV : {0}", number1 / number2);
        }

        public void Run()
        {
            RunCalc calc = (RunCalc)Delegate.Combine(new RunCalc(Sum), new RunCalc(Multiply), new RunCalc(Divide));
            calc(20, 4);
        }
    }
}

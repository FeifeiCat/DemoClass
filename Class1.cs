using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoClass
{
    public class Class1
    {

        public int Sum(params int[] args)
        {
            int result = 0;
            foreach (int item in args)
            {
                result += item;
            }
            return result;
        }
    }
}

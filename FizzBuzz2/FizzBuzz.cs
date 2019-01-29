using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz2
{
    public class FizzBuzz
    {
        public string Get(int num)
        {
            if (num % 3 == 0) 
            {
                return "Fizz";
            }
            return num.ToString();
        }
    }
}

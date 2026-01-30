using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SV.Services
{
    public class OddOrEvenService
    {
        public string OddOrEven(double num)
        {
            return $"{num} is {(num % 2 == 0 ? "even" : "odd")}.";
        }
    }
}

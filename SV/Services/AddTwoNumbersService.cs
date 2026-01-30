using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SV.Services
{
    public class AddTwoNumbersService
    {
        public string AddTwoNumbers(double one, double two)
        {
            return $"The sum of {one} and {two} is {one + two}.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SV.Services
{
    public class ReverseItNumericService
    {
        public string? ReverseIt(string str)
        {
            char[] arr = str.ToCharArray();
            if (!Array.TrueForAll(arr, char.IsAsciiDigit)) return null;
            return $"{str} -> {[.. arr.Reverse()]}";
        }
    }
}

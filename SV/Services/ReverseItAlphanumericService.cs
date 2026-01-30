using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SV.Services
{
    public class ReverseItAlphanumericService
    {
        public string? ReverseIt(string str)
        {
            char[] arr = str.ToCharArray();
            if (!Array.TrueForAll(arr, char.IsAsciiLetterOrDigit)) return null;
            Array.Reverse(arr);
            return $"{str} -> {new string(arr)}";
        }
    }
}

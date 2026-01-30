using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SV.Services
{
    public class MadLibService
    {
        public string MadLib(string w0, string w1, string w2, string w3, string w4, string w5, string w6, string w7, string w8, string w9)
        {
            return $"There once was a(n) {w0} {w1} that lived in a(n) {w2}.\nSome {w3} would {w4} and {w5} {w6} nearby.\nThis {w7} disturbed the {w1} and led to the {w3} being {w8} {w9}.";
        }
    }
}

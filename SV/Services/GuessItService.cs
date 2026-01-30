using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SV.Services
{
    public class GuessItService
    {
        public string GuessIt(int num, int min, int max)
        {
            int rng = Random.Shared.Next(min, max + 1);
            if (num < rng)
            {
                return $"{num} is less than {rng}.";
            }
            else if (num > rng)
            {
                return $"{num} is greater than {rng}.";
            }
            else
            {
                return $"You guessed {rng} correctly!";
            }
        }
    }
}

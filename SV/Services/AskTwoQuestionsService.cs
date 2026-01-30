using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SV.Services
{
    public class AskTwoQuestionsService
    {
        public string AskTwoQuestions(string one, string two)
        {
            return $"Your name is {one} and you woke up at {two}.";
        }
    }
}

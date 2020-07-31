using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallenges_W1D4
{
    public class MethodsForWhiteboard
    {
        public int Subtract(int numOne, int numTwo)
        {
            int difference = numOne - numTwo;
            return difference;
        }

        public string Phrase(string one, string two)
        {
            string newString = one + " " + two;
            return newString;
        }
    }
}

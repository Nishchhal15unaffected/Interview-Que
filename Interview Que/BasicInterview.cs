using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Que
{
    public class BasicInterview
    {
        public BasicInterview() { }
        // in a string vowel is presented or not
        public bool IsVowelPresent(string str)
        {
           foreach (char ch in str)
           {
                if (ch == 'A' || ch == 'I' || ch == 'O' || ch == 'U' || ch == 'E' || ch == 'a' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'e')
                {
                    return true;
                }
           }
            return false;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions
{
    public class ReverseString
    {
        public string Reverse(string name)
        {
            char[] c = name.ToCharArray();
            int n = c.Length;

            for (int i = 0; i < n / 2; i++)
            {
                (c[i], c[n - 1 - i]) = (c[n - 1 - i], c[i]);
            }

            return new string(c);
        }
    }

}

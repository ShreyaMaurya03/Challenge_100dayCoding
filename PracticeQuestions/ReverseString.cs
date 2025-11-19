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


        public string NonRepeatedCharacter()
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            string input = "swiss";

            char[] characters = input.ToCharArray();
            foreach (char c in characters)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            foreach (char c in characters)
            {
                if (charCount[c] == 1)
                {
                    return c.ToString();
                }
            }

            return string.Empty;

        }
    }
    }



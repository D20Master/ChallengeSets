using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }

            if (ignoreCase)
            {
                var lowerWords = string.Join(" ", words).ToLower();
                return lowerWords.Contains(word.ToLower());
            }
            else
            {
                return words.Contains(word);
            }
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 2)
            {
                return true;
            }
            else if (num <= 1 || num % 2 == 0)
            {
                return false;
            }
            else
            {
                var limit = (int)Math.Floor(Math.Sqrt(num));

                for (int i = 3; i <= limit; i++)
                {
                    if (num%i==0)
                    {
                        return false;
                    }
                }

                return true;
            }
            
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            try
            {
                var ch = str.ToCharArray().Where(x => str.Count(i => i == x) == 1).Last();
                return str.IndexOf(ch);
            }
            catch
            {
                return -1;
            }
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var priorNum = 0;
            var count = 0;
            var maxCount = 0;

            foreach (var num in numbers)
            {
                if (priorNum == num)
                {
                    count++;

                    if (count > maxCount)
                    {
                        maxCount = count;
                    }

                }
                else
                {
                    count = 0;
                }

                priorNum = num;
            }

            return maxCount+1;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthList = new List<double>();

            if (n<=0 || elements == null)
            {
                return nthList.ToArray();
            }

            for (int i = n - 1; i < elements.Count(); i += n)
            {
                nthList.Add(elements[i]);
            }

            return nthList.ToArray();

        }
    }
}

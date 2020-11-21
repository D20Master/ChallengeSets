﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
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
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}

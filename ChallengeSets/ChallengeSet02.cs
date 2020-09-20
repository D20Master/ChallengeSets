using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2) == 0;
        }

        public bool IsNumberEven(int number)
        {
            return(number % 2) == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return (Math.Abs(num) % 2) == 1;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else if (numbers.Count<double>() == 0)
            {
                return 0;
            }
            else
            {
                double maxNum = numbers.Max<double>();
                double minNum = numbers.Min<double>();
                return maxNum + minNum;
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length>str2.Length) ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            return (numbers != null) ? numbers.Sum(): 0;
        }

        public int SumEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}

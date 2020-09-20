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
            int num = 0;
            if (numbers == null )
            {
                return num;
            }
            else
            {
                foreach (var item in numbers)
                {
                    if (item % 2 == 0)
                    {
                        num += item;
                    }
                }
                return num;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return (numbers != null) ? (Math.Abs(numbers.Sum()) % 2) == 1 : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int count = 0;

            for (int i = 1; i < number; i++)
            {
                if (i % 2 == 1)
                    count++;
            }

            return count;
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            for (int i = startNumber + n; i > 0; i--)
            {
                if (i % n== 0)
                {
                    return i;
                }
            }

            return 0;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue==0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            try
            {
                return numbers.Count() == 0 ? false : numbers == null ? false : numbers.SequenceEqual(numbers.OrderBy(x => x).ToArray());

            }
            catch 
            {
                return false;
            }
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var sum = 0;
            try
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sum += numbers[i + 1];
                    }
                }
                return sum;
            }
            catch
            {
                return 0;
            }

        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var sentence = "";
            try
            {
                sentence = string.Join(" ", words.Select(x => x.Replace(" ", string.Empty)).Where(x => x.Length > 0)) + ".";
                return sentence.Length > 1 ? sentence : "";
            }
            catch
            {
                return "";
            } 
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            try
            {
                return elements.Where(x => x % 4 == 0).ToArray();
            }      
            catch 
            {
                return new double[0];
            }

        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}

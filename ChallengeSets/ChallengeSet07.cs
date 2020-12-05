using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengeSets
{
    public class ChallengeSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            var count = 0;

            if (businesses == null)
            {
                return  0;
            }

            foreach (var business in businesses)
            {
                if (business.TotalRevenue - business.TotalExpenses < 0)
                {
                    count++;
                }
            }

            return count;
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            var profitableBus = new List<string>();

            foreach (var business in businesses)
            {
                if (business.TotalRevenue - business.TotalExpenses > 0)
                {
                   profitableBus.Add(business.Name);
                }
            }

            return string.Join(",", profitableBus);
        }

        public string GetNameOfHighestParentCompany(Business business)
        {
           // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C

            if (business.ParentCompany == null)
            {
                return business.Name;
            }

            var parent = business.ParentCompany;

            do
            {
                if (parent.ParentCompany == null)
                {
                    return parent.Name;
                }
                else
                {
                    parent = parent.ParentCompany;
                }

            } while (parent != null);

            return null;
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            throw new NotImplementedException();
        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}

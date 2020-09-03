using System;
namespace ChallengeSets
{
    public class ChallengeSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
           return num1==num2;
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Add(int number1, int number2)
        {
            throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            throw new NotImplementedException();
        }

        public long Multiply(long factor1, long factor2)
        {
            throw new NotImplementedException();
        }

        public string GetGreeting(string nameOfPerson)
        {
            return(nameOfPerson == "") ? "Hello!" : $"Hello, {nameOfPerson}!"; 
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}

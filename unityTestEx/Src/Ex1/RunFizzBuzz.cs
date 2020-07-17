using System;

namespace unityTestEx.Src.Ex1
{
    public class RunFizzBuzz
    {
        public string ReturnGameResultAccordingToNumber(int Entry)
        {
            if(isMultipleOfThree(Entry) & isMultipleOfFive(Entry))
            {
                return "FizzBuzz";
            }
            else
            if(isMultipleOfThree(Entry))
            {
                return "Fizz";
            }
            else
            if(isMultipleOfFive(Entry))
            {
                return "Buzz";
            }
            else
            {
                return Entry.ToString();
            }
        }

        private bool isMultipleOfThree (int Val)
        {
            if(Val % 3 == 0)
                return true;

            return false;
        }

        private bool isMultipleOfFive (int Val)
        {
            if(Val % 5 == 0)
                return true;

            return false;
        }
    }
}
  
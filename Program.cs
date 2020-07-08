using System;
using unityTestEx.Src.Ex1;

namespace unityTestEx
{
    class Program
    {
        static void Main(string[] args)
        {
            RunFizzBuzz FizzBuzz = new RunFizzBuzz();

            for(int i = 0; i < 101; i++)
            {
                Console.WriteLine(FizzBuzz.ValidateEntry(i));
            }
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using unityTestEx.Src.Ex1;

namespace unityTestEx_Tests.Ex1
{
    class RunFizzBuzzTests
    {
        private string Expected = "Buzz";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestResults()
        {
            RunFizzBuzz FizzBuzz = new RunFizzBuzz();

            Assert.AreEqual
            (
                Expected,
                FizzBuzz.ReturnGameResultAccordingToNumber(100)
            );
        }
    }
}

using System;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test11()
        {
            Console.WriteLine("Hello!");
            Assert.Pass();
        }

        [Test]
        public void Test12()
        {
            Console.WriteLine("Good Morning!");
            Assert.Pass();
        }
    }
}
using System;
using NUnit.Framework;

namespace TestProject2
{
    public class Tests
    {
        [Test]
        public void Test21()
        {
            Console.WriteLine("Guten morgen!");
            Assert.Pass();
        }

        [Test]
        public void Test22()
        {
            Console.WriteLine("Buongiorno!");
            Assert.Pass();
        }
    }
}
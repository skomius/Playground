using NUnit.Framework;
using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace NunitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var list = new List<int>() { 1, 2};
            Debug.WriteLine("Test");
            Console.WriteLine(String.Join(',',list));
        }
    }
}
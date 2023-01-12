using System;
using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Tests
{
    public class Playground
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public Playground(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Test()
        {
            _testOutputHelper.WriteLine("Hello");
            Console.WriteLine("Hello");
            Debug.Print("Hello");
            Debug.WriteLine("Hello");
        }
    }
}

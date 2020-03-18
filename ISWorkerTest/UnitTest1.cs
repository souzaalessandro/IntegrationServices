using System;
using Xunit;

namespace ISWorkerTest
{
    public class TestReference
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(4, Add(2,2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.NotEqual(5, Add(2,2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }

    }
}

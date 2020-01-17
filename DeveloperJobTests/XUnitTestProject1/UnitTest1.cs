using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int x = 1;
            int y = 1;

            int z = x + y;
            int expected = 2;

            Assert.Equal(expected, z);
        }

        [Fact]
        public void Test2()
        {
            int x = 1;
            int y = 1;

            int z = x + y;
            int expected = 3;

            Assert.Equal(expected, z);
        }
    }
}

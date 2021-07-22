using System;
using Xunit;
using Task2;

namespace TestProjectTask2
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 2, 1, 0, 3, 1, 0, 2, 1, 0, 0, 0 }, 5)]
        [InlineData(new int[] { 3, 4, 0, 2, 0, 0, 0, 0, 1, 2, 0, 1, 0, 1, 0 }, 5)]
        [InlineData(new int[] { 0 }, 1)]
        [InlineData(new int[] { 1, 1, 1, 0 }, 4)]
        [InlineData(new int[] { 3, 2, 1, 0, 1, 0, 2, 1, 0, 1, 0, 2, 1, 0, 1, 0 }, 4)]
        public void Test1(int[] data, int n)
        { 
            //Arrange + Act
            Program program = new Program(data);

            //Assert
            Assert.Equal(n, program.Depth);
        }
    }
}

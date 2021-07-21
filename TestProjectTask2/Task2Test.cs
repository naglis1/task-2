using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace TestProjectTask2
{
    [TestClass]
    public class Task2Test
    {
        readonly int[] data = { 2, 1, 0, 3, 1, 0, 2, 1, 0, 0, 0 };
        readonly int[] data1 = { 3, 4, 0, 2, 0, 0, 0, 0, 1, 2, 0, 1, 0, 1, 0 };
        readonly int[] data2 = { 0 };
        readonly int[] data3 = { 1, 1, 1, 0 };
        readonly int[] data4 = { 3, 2, 1, 0, 1, 0, 2, 1, 0, 1, 0, 2, 1, 0, 1, 0 };

        [TestMethod]
        public void TestMethod()
        {
            //Arrange + Act
            Program program = new Program(data);

            //Assert
            Assert.AreEqual(5, program.depth);
        }
        [TestMethod]
        public void TestMethod1()
        {
            Program program = new Program(data1);
            Assert.AreEqual(5, program.depth);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Program program = new Program(data2);
            Assert.AreEqual(1, program.depth);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Program program = new Program(data3);
            Assert.AreEqual(4, program.depth);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Program program = new Program(data4);
            Assert.AreEqual(4, program.depth);
        }
    }
}

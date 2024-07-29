namespace Lab_exam_sdm
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            MathEngine mathEngine = new MathEngine();
            int result = mathEngine.Add(3, 5);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestSubtract()
        {
            MathEngine mathEngine = new MathEngine();
            int result = mathEngine.Subtract(10,4);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            MathEngine mathEngine = new MathEngine();
            int result = mathEngine.Multiply(2,3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestDivide()
        {
            MathEngine mathEngine = new MathEngine();
            int result = mathEngine.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        
       /* public void TestDividedByZero()
        {
            MathEngine mathEngine = new MathEngine();
            int result = mathEngine.Divide(10,0);
            Assert.AreEqual(0,0);
        }*/

    }
}
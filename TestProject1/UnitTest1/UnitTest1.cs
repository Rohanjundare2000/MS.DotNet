
namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num1 = 67;
            int num2 = 3;
            int expectedValue = 70;


            MathEngine math= new MathEngine();
            int actualData = math.Add(num1, num2);
            Assert.AreEqual(expectedValue, actualData);

        }


        [TestMethod]
        public void TestMethod2()
        {
            int num1 = 67;
            int num2 = 3;
            int expectedValue = 70;


            MathEngine math = new MathEngine();
            int actualData = math.Sub(num1, num2);
            Assert.AreEqual(expectedValue, actualData);

        }

        [TestMethod]
        public void TestMethod3()
        {
            String A = "Rohan";

            StringReturn r = new StringReturn();


        }

    }
}
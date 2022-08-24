using ConsoleApp12;
namespace TestProje2ct2
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void TestAdd()
        {
            Calculator c = new Calculator();
            int result = c.Add(12, 20);
            Assert.AreEqual(32, result);
        }
    }
}
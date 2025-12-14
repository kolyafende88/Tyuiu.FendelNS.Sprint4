using Tyuiu.FendelNS.Sprint4.Task7.V4.Lib;
namespace Tyuiu.FendelNS.Sprint4.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ShouldReturnSumOfOddNumbers()
        {
            
            string input = "382976421897";
            int expectedSum = 36;
            int n = 3;
            int m = 4;
            DataService dataService = new DataService();
            int actualSum = dataService.Calculate(n, m, input);
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}
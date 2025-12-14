using Tyuiu.FendelNS.Sprint4.Task1.V17.Lib;
namespace Tyuiu.FendelNS.Sprint4.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 3 };
            int res = ds.Calculate(array);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
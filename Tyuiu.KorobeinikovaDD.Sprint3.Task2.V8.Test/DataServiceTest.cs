using Tyuiu.KorobeinikovaDD.Sprint3.Task2.V8.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint3.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 0.313;
            Assert.AreEqual(wait, res);
        }
    }    
}
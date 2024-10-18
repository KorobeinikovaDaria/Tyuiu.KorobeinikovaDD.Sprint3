using Tyuiu.KorobeinikovaDD.Sprint3.Task6.V16.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint3.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

      
            int startValue = 1;
            int stopValue = 2;
            
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
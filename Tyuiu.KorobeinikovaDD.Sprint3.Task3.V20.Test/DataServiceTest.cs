using Tyuiu.KorobeinikovaDD.Sprint3.Task3.V20.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint3.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string str = "fffg";
            char ch = 'f';
            double res = ds.GetCharCount(str, ch);

            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
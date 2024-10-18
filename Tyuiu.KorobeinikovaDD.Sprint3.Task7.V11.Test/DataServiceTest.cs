using Tyuiu.KorobeinikovaDD.Sprint3.Task7.V11.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint3.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();


            int startValue = -5;
            int stopValue = 5;

            int len = (stopValue - startValue) + 1;

            double[] wait;
            wait = new double[len];

            wait[0] = 20.36;
            wait[1] = 15.42;
            wait[2] = 10.99;
            wait[3] = 7.43;
            wait[4] = 4.33;
            wait[5] = 1.00;
            wait[6] = 0.00;
            wait[7] = -8.87;
            wait[8] = -13.03;
            wait[9] = -16.53;
            wait[10] = -19.60;

            double[] valueArray;
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(wait, valueArray);
        }
    }
    
}
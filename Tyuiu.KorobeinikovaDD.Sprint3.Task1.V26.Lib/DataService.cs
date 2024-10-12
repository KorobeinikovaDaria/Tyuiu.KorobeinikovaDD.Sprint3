using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KorobeinikovaDD.Sprint3.Task1.V26.Lib
{
    public class DataService : ISprint3Task1V26
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i = startValue;
            while (i <= stopValue)
            {
                sumSeries = sumSeries + ((Math.Pow(6, 2) / Math.Pow(Math.Pow(value, i), 2)));
                i++;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}

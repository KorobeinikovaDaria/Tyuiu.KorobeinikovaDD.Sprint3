using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KorobeinikovaDD.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double sumSeries = 1;
            int i = startValue;
            do
            {
                sumSeries = sumSeries * (1/(Math.Pow((Math.Cos(5)+1), 2)));
                i++;
            } while (i <= stopValue);
            return Math.Round(sumSeries, 3);
        }
    }
}

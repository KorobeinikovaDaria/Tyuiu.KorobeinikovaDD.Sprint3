using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KorobeinikovaDD.Sprint3.Task3.V20.Lib
{
    public class DataService : ISprint3Task3V20
    {
        public int GetCharCount(string value, char item)
        {
            int count = 0;
            foreach ( char i in value)
            {
                if (i == item)
                {
                    count++;
                }
            }
            return count;
        }
        
    }
}

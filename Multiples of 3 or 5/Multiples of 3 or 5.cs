// See https://aka.ms/new-console-template for more information

namespace Multiples_of_3_or_5
{
    static class Multiples
    {
        public static int Multiples3Or5(int num)
        {
            int result = 0;
            int sum = 0;
            for (int i = 0; i < num ; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    result++;
                    sum += i;
                }
                else if (i % 5 == 0 || i % 3 == 0)
                {
                    result++;
                    sum += i;
                }
            }

            if (sum > 0)
            {
                return sum;
            }
            else
            {
                return result;
            }
            
        }
    }
}
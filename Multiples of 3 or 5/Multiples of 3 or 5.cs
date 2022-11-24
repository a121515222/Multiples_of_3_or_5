// See https://aka.ms/new-console-template for more information

namespace Multiples_of_3_or_5
{
    public static class Multiples
    {
        public static int Multiples3Or5(int num)
        {
            var result = 0;
            var sum = 0;
            for (var i = 0; i < num ; i++)
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
            return result > 0 ? sum : result;
        }
    }
}
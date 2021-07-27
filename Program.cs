using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindingGap.Do(805306373));
        }
    }

    public static class FindingGap
    {
        public static int Do(int N)
        {
            var bit = Convert.ToString(N, 2);

            var count = 0;
            var biggest = 0;
            var tempCounter = 0;

            for (int i = 0; i < bit.Length; i++)
            {
                if (bit[i] == '0')
                {
                    count++;
                }

                if (count > biggest) biggest = count;

                if (bit[i] == '1')
                {
                    if (biggest > tempCounter)
                        tempCounter = biggest;
                    count = 0;
                }

            }

            return tempCounter;
        }
    }
}

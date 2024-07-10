using System;

namespace week_02_EX_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double count = 0.0;
            while (count != 10.0)
            {
                count = count + 1.0;
                Console.Write(count / 10);
                Console.ReadLine();
            }
        }
    }
}
// It didn't stop because 'count' never becomes exactly '0.1'.
// Since count is never exactly '1.0', the loop keeps running indefinitely.
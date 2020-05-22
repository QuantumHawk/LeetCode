using System;
using System.Linq;

namespace dailyTasks.BitManipulation
{
    public class CountingBit
    {
        public static int[] CountingBits(int num)
        {
            string binary = Convert.ToString(num, 2);
            int count = 0;
            
            foreach (char c in binary)
            {
                if (c == '1') count++;
            }

            int i = count;
            int[] res = new int[++count];
            res[0] = i;
            i = 1;
            
            for (int j =0;j<binary.Length;j++)
            {
                if (binary[j] == '1')
                {
                    count = j + 1;
                    res[i] = count;
                    i++;
                }
            }

            return res;
        }
        /*public static void Main(string[] args)
        {
            int[] res = CountingBits(161);
            Console.ReadLine();
        }*/
    }
    
}
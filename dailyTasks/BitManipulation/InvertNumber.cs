using System;

namespace dailyTasks.BitManipulation
{
    public class InvertNumber
    {
        /// <summary>
        /// Returns binary representation string.
        /// </summary>
        static string GetIntBinaryString(int n)
        {
            char[] b = new char[32];
            int pos = 31;
            int i = 0;
        
            while (i < 32)
            {
                if ((n & (1 << i)) != 0)
                {
                    b[pos] = '1';
                }
                else
                {
                    b[pos] = '0';
                }
                pos--;
                i++;
            }
            return new string(b);
        }
        
        /*public static void Main(string[] args)
        {
            int nine = 9;
            // invert the binary value of a integer variable
            int num2 = ~nine;
            //If you're worried about only the last byte
            int notnine1 = ~nine & 0x000000FF;
            //if you're only interested in the last nibble:
            int notnine2 = 15 - nine;
            //Console.WriteLine(res);
            
            // Demonstrate XOR for two integers.
            int a = 5550 ^ 800;
            Console.WriteLine(GetIntBinaryString(5550));
            Console.WriteLine(GetIntBinaryString(800));
            Console.WriteLine(GetIntBinaryString(a));
            Console.WriteLine();
        
            // Repeat.
            int b = 100 ^ 33;
            Console.WriteLine(GetIntBinaryString(100));
            Console.WriteLine(GetIntBinaryString(33));
            Console.WriteLine(GetIntBinaryString(b));
        }*/
    }
}
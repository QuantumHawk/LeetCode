using System;
using System.Runtime.ConstrainedExecution;

namespace dailyTasks.BitManipulation
{
    public class GetHashCode
    {
        //https://www.dotnetperls.com/gethashcode
        /*[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        public override unsafe int GetHashCode()
        {
            fixed (char* str = this)
            {
                char* chPtr = str;
                int num = 352654597;
                int num2 = num;
                int* numPtr = (int*)chPtr;
                for (int i = this.Length; i > 0; i -= 4)
                {
                    num = (((num << 5) + num) + (num >> 27)) ^ numPtr[0];
                    if (i <= 2)
                    {
                        break;
                    }
                    num2 = (((num2 << 5) + num2) + (num2 >> 27)) ^ numPtr[1];
                    numPtr += 2;
                }
                return (num + (num2 * 1566083941));
            }
        }
        static void Main()
        {
            string value = "";
            for (int i = 0; i < 10; i++)
            {
                value += "x";
                // This calls the unsafe code listed on this page.
                Console.WriteLine("GETHASHCODE: " + value.GetHashCode());
            }
        }*/
    }
}
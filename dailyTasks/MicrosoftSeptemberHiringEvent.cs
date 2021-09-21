using System;
using System.Collections.Generic;
using System.Text;

namespace dailyTasks
{
    public class MicrosoftSeptemberHiringEvent
    {
        //https://leetcode.com/problems/replace-all-s-to-avoid-consecutive-repeating-characters/discuss/902331/C-fastest-solution
        public static string ModifyString(string riddle)
        {
            int min = 97;
            char q = '?';
            string res = "";
            
            for(int i = 0; i < riddle.Length; i++)
            {
                int current = riddle[i];
                if (current == q)
                {
                    int next = min;

                    while (i > 0 && next == riddle[i - 1])
                        next++;

                    while (i < riddle.Length - 1 && next == riddle[i + 1])
                        next++;

                    while (i > 0 && next == riddle[i - 1])
                        next++;

                    var sb = new StringBuilder(riddle);
                    sb[i] = Convert.ToChar(next);
                    riddle = sb.ToString();
                }
            }
            return riddle;
        
        }

        /*In this task we need to do following things:
We need to write a function which returns sum of digits for a given number.
We need to make a hash map where the key is the sum of digits of the given number and the value is this number.
Then we will take each given number and put sum of it’s digits and the number itself into the hash map
If the hash map contains this sum we check if sum of our number and number from the map is bigger than maximum encountered sum of numbers.
If yes we save this sum as the maximum sum and save in the hash map given number if it is bigger than the number from the map.*/
        //https://molchevskyi.medium.com/numbers-with-equal-digit-sum-c8a7e01ad7db
        //https://stackoverflow.com/questions/64294018/calculating-the-time-and-space-complexity-of-maximum-sum-of-two-elements-whose-d
        public static int maxSumDigits(int[] A)
        {
            var dict = new Dictionary<int, int>();
            //  // Maximum sum of given numbers
            int max_sum = 0;

            foreach (var num in A)
            {
                int s = digit(num);
                //// If we have no such sum of digits in the map
                ///   // add this sum to the map as a key and the number 
                // as a value 
                if (!dict.ContainsKey(s)) {
                    dict[s] = num;
                }
                else {
                    // if we have the sum of digits in the map
                    // if sum of current number and number from 
                    // the map with the same sum of digits are bigger than
                    // maximum encountered sum then update the maximum sum
                    max_sum = Math.Max(max_sum, dict[s] + num);
                    // Save current number as value for current sum 
                    // of digits if it is bigger than number from the map
                    dict[s] = Math.Max(num, dict[s]);
                }
            }

            
            // if the are no numbers with equal sum return -1
            return max_sum >0 ? max_sum : -1;

        }

        //// this function returns sum of digits of a given number
        public static int digit(int num)
            {
                var n = num;
                var result = 0;

                while (n > 0)
                {
                    result += n % 10;
                    n /= 10;
                }

                return result;
            }
        
        //https://leetcode.com/problems/jump-game-iii/
        //https://stackoverflow.com/questions/63132225/maximum-distance-two-frogs-can-create-by-starting-at-any-index-in-a-list-in-on
        public static int FrogJumps(int[] blocks)
            {
                var blockLen = blocks.Length;
                if (blockLen< 2) return blockLen;
                
                int max = 0;
                int[] right = new int[blockLen];
                int[] left = new int[blockLen];

                for (int i = 1; i < blockLen; i++)
                    left[i] = blocks[i - 1] >= blocks[i] ? left[i - 1] + 1 : 0;

                for (int i = blockLen - 2; i >= 0; i--)
                    right[i] = blocks[i + 1] >= blocks[i] ? right[i + 1] + 1 : 0;

                for (int i = 0; i < blocks.Length; i++)
                    max = Math.Max(max, left[i] + right[i] + 1);

                return max;
            }

        /*public static void Main(string[] args)
        {

            var f = new int[]{51,71,17,41};
            var r = maxSumDigits(f);
                Console.WriteLine();

        }*/
    }
}
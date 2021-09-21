using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dailyTasks
{
    public class Input
    {
        /*public static void Main(String[] args) {
            //int sum = IDontRememberWhatIsIt.Sum(123L); ==6?
            //Console.WriteLine(sum.ToString());
            
            /*List<int> list = new List<int>();
            list.Add(3);  //3 4 1 2 5 6 9 0 1 2 3 1


             int j = IDontRememberWhatIsIt.Jump(list);
             int g = IDontRememberWhatIsIt.jump_over_numbers(list);
             Console.WriteLine(j);
             Console.WriteLine(g);#1#

            //1.
            // List<int> heroes = new List<int>() {3, 5, 10};//{6,7,4,1,3};
            // int n = 2;
            // int m = Heroes.getTotalTime(heroes,n);

            //2.
            //int res = BrokenDevice(x,y);
            //Console.WriteLine(res.toString());

            //3.
            // String encoded =  EncodeMessage.encode("эй , какая крутая фича !");
            // int kkkv = 0;

            //4.
            // List<int> heroes = new List<int>(){3,2,2,1};
            // int j = 0;
            // j = Boats.getNumberOfBoats(heroes,3); //1
            // int g = 0;

            Console.ReadLine();
        }*/
    }
    public static class Heroes
    {
        public static int getTotalTime(List<int> heroes, int n) {

            //не работает должным образом,
            //надо ковырять как работал джава код, с итератором не проканало
            int result = 0;
            int min = 0;
            int max = 0;
            int[] dumpArray = new int[n];
            foreach(int i in heroes) {
                max = 0;
                for (int j = 0; j < dumpArray.Length; j++) {

                    if (dumpArray[j] == 0) {
                        dumpArray[j] = i;
                    }
                    if (min > dumpArray[j] || min == 0)
                        min = dumpArray[j];
                }
                result += min;
                for (int j = 0; j < dumpArray.Length; j++) {
                    dumpArray[j] -= min;
                    if (max < dumpArray[j]) max = dumpArray[j];
                }
            }
            return result+=max;
        }
    }
    public class BrokenDevice
    {
        //1. если x<0  а y>=0 не умножать, к.т. x>0 умножать
        //2. // || x ==1)) { //5, 10 x > 0
        // 1;5 5;10 очень большие числа (для которых лучше много раз умножить число а потом начать вычитать
        private static int brokenDevice(int x,int y) {
            int count = 0;
            while (y != x) {
                if (y % 2 > 0 || y < x) {
                    y++;
                } else {
                    y /= 2;
                }
                count++;
            }
            return count;
        }
    }

    public class Boats
    {
        public static int result = 0;
        //1. sort array descending
        //2. cut all num which fit limit
        //3. foreach num search a pair (x+y)==limit
        //4. нет никого больше лимита
        //https://algorithms.tutorialhorizon.com/minimum-boats-required-to-rescue-people/
        public static int getNumberOfBoats(List<int> dwarfs, int limit) {

            int[] array = new int[dwarfs.Count];  
            //dwarfs.Sort();
            //dwarfs.Reverse();
            dwarfs.Sort((a, b) => b.CompareTo(a));
            array = dwarfs.ToArray();
            return numberOfBoats(limit,array,0, array.Length-1);
        }
        
        static int numberOfBoats(int limit, int[] wt, int next, int last) {

            if (last < next)
                return result;

            if (wt[next] == limit || (wt[next] + wt[last]) > limit) {
                result++;
                return numberOfBoats(limit, wt, next+1, last);
            }

            if (((wt[next] + wt[last]) != limit) && (wt[next] + wt[last]) >= limit) return result;
            result++;
            return numberOfBoats(limit, wt, next+1, last-1);
        }
    }

    public static class EncodeMessage
    {
        public static bool CheckOnP(char[] array)
        {
            bool f = false;
            if(array.Length==1) {
                char[] c = {'.', ',', '-', ':', ';', '?', '!'};
                for (int i = 0; i < c.Length; i++) {
                    if (array[0] == c[i]) f = true;
                }
            }
            return f;
        }
        
        public  static char[] CopyArray(char[] k_array,char[] c_array)
        {
            for(int z = 0; z<k_array.Length;z++)
            {
                c_array[z] = k_array[z];
            }
            return c_array;
        }
        public  static char[] CopyArrayBack(char[] k_array,char[] c_array)
        {
            for(int z = 1; z<k_array.Length;z++)
            {
                c_array[z-1] = k_array[z];
            }
            return c_array;
        }
        public static string encode(string text){

            string result = "";
            string[] array = text.Split(" ");
            for(int i=0; i<array.Length; i++){
                char[] k_array = array[i].ToCharArray();
                if (!CheckOnP(k_array))
                {
                    char[] c_array = new char[array[i].Length + 1];
                    char[] r_array = new char[array[i].Length];

                    CopyArray(k_array, c_array);
                    char temp;
                    temp = c_array[0];
                    c_array[0] = c_array[c_array.Length - 1];
                    c_array[c_array.Length - 1] = temp;

                    CopyArrayBack(c_array, r_array);
                    result += new string(r_array) + "оп" + " ";
                }
                else
                    result += new string(k_array) + " "; //String.valueOf(k_array) + " ";
            }
            return result.Trim();
        }
    }
    
    public static class IDontRememberWhatIsIt
    {
        public static int Sum (long n)
        {
            n = Math.Abs(n);
            int Sum = 0;

            char[] charArray = ("" + n).ToCharArray();
            foreach (char c in charArray)
            {
                Sum += int.Parse(c.ToString()); //(String.valueOf(c));
            }
            return Sum;
        }
        public  static  int Jump(List<int> list)
        {
            int jumps = 0;
            int size = list.Count;
            for (int i = 0, position = 0; i < size; i = position )
            {
                if (position >= size) {
                    jumps++;
                    return jumps;
                }
                if (list[i] == 0)  return -1;
                position = list[i];
                jumps++;
            }
            return jumps;
        }

        public static int jump_over_numbers(List<int> list) {
            int pos = 0;
            int ans = 0;

            while (pos < list.Count) {
                if (list[pos] == 0) {
                    return -1;
                }
                ans++;
                pos += list[pos];
            }

            return ans;
        }
        
    }
}
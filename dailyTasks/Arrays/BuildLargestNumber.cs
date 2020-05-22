using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace dailyTasks.Arrays
{
    /** O(nlogn)
 179. Largest Number
 https://leetcode.com/problems/largest-number/#/description
 Given a list of non negative integers, arrange them such that they form the largest number.
 For example, given [3, 30, 34, 5, 9], the largest formed number is 9534330.
 Note: The result may be very large, so you need to return a string instead of an integer.
 Credits:
 Special thanks to @ts for adding this problem and creating all Snake_3 cases.
 
 We use a.b to represent the concatenation of non-negative integers a and b .

Theorem:

Let a, b, and c be non-negative integers. If a.b > b.a and b.c > c.b , we have a.c > c.a .

Proof:

We use [a] to denote the length of the decimal representation of a . For example, if a = 10 , we have [a] = 2 .

Since a.b > b.a and b.c > c.b , we have

a * 10^[b] + b > b * 10^[a] + a
b * 10^[c] + c > c * 10^[b] + b

, which is equivalent to

a * (10^[b] - 1) > b * (10^[a] - 1)
b * (10^[c] - 1) > c * (10^[b] - 1)

Obviously, 10^[a] - 1 > 0 , 10^[b] - 1 > 0 , and 10^[c] - 1 > 0 . Since c >= 0 , according to the above inequalities, we know that b > 0 and a > 0 . After multiplying the above two inequalities and cancelling b and (10^[b] - 1) , we have

a * (10^[c] - 1) > c * (10^[a] - 1)

This is equivalent to

a * 10^[c] + c > c * 10^[a] + a

, which means a.c > c.a 
 */
// https://discuss.leetcode.com/topic/7235/my-3-lines-code-in-java-and-python
// https://discuss.leetcode.com/topic/8018/my-java-solution-to-share
   
    public class BuildLargestNumber
    {

        public static string LargestNumber(int[] nums) {
            int left = 0;
            int length = nums.Length;
            int[] str = InsertionSort_FastComparator(nums, left, length + left - 1);

            //The new number should not start with 0 unless it is 0
            if (str[0].Equals(0) ) return "0"; // if only zeros in array
            
            return String.Join("",str);
        }
    
        public  static  bool comp(int a, int b){
            if(a!=0 && b!=0)
                return (a * Math.Pow(10,(1+(int)Math.Log10(b))) +b)
                       > ( b* Math.Pow(10,(1+(int)Math.Log10(a))) + a);
            else 
                return a > b;
        }
    
        private static int[] InsertionSort_FastComparator(int[] keys, int lo, int hi)
        {
            Debug.Assert(keys != null);
            Debug.Assert(lo >= 0);
            Debug.Assert(hi >= lo);
            Debug.Assert(hi <= keys.Length);

            int i, j;
            int t;
            for (i = lo; i < hi; i++)
            {
                j = i;
                t = keys[i + 1];
                while (j >= lo && comp(t, keys[j]))
                {
                    keys[j + 1] = keys[j];
                    j--;
                }
                keys[j + 1] = t;
            }

            return keys;
        }
        
        #region Slow
        public static string largestNumber(int[] nums) {
            string[] str = new string[nums.Length];
            for(int i=0; i<nums.Length; i++) {
                str[i] = nums[i].ToString();
            }

            int left = 0;
            int length = nums.Length;
            str = InsertionSort(str, left, length + left - 1, new Comparison<string>((string s1, string s2) => (s2 + s1).CompareTo(s1 + s2)));  
            
            //Define comparator Array.Sort(str, (string s1, string s2) => (s2 + s1).CompareTo(s1 + s2));

            //The new number should not start with 0 unless it is 0
            if (str[0].Equals("0") ) return "0"; // if only zeros in array
            
            return String.Join("", str);
        }
        private static string[] InsertionSort(string[] keys, int lo, int hi, Comparison<string> comparer)
        {
            Debug.Assert(keys != null);
            Debug.Assert(lo >= 0);
            Debug.Assert(hi >= lo);
            Debug.Assert(hi <= keys.Length);

            int i, j;
            string t;
            for (i = lo; i < hi; i++)
            {
                j = i;
                t = keys[i + 1];
                while (j >= lo && comparer(t, keys[j]) < 0)
                {
                    keys[j + 1] = keys[j];
                    j--;
                }
                keys[j + 1] = t;
            }

            return keys;
        }
        #endregion
        // Функция расчитывающая количество чисел во введённом числе...
        // Пока число делится на 10
        // увеличиваем счётчик считающий кол-во разрядов в числе
        public  static int Rasriad(int enterNumber)
        {
            int n = enterNumber, x = 0;
            while(n != 0){
                n /= 10;
                x++;
            }
            return x;
        }

        public void SeparateToRazriad()
        {
            int enterNumber=30, // сохраняем введённое число
                lenght = 0, // сохраняем "длину" числа, кол-во разрядов: 1234567 = 7 чисел
                indexRas,  // последний запоминаемый разряд числа
                dec = 1, // делитель, "отрывающий" разряды числа, после каждого прохода, умножается на 10
                z;
            // определяет количество цифр в нем.
            lenght = Rasriad(enterNumber);

            // Вычисляем максимальное число, которым мы начнём "отрывать" разряды у введённого числа
            for (  int j = 1; j < lenght; j++)
                dec *= 10;

            // Процесс "отрыва" разрядов и вывод через пробел
            for (int i = 0; i < lenght; i++)
            {
                indexRas = enterNumber / dec % 10; // Отрываем первый разряд в числе и сохраняем в переменной
                dec /= 10; // уменьшаем делитель для последующего разряда в числе
            }
        }

        /*public static void Main(string[] args)
        {
            string res = LargestNumber(new[] {7, 9, 10, 90, 91, 1999});
            Console.ReadLine();

        }*/
    }
    
    
}
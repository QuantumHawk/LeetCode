using System;
using System.Collections.Generic;
using System.Linq;

namespace dailyTasks.StringManipulation
{
    public class AnagramGetMinimumDiff
    {
        public static int Check(char[] word1, char[] word2)
        {
            int res = word1.Sum(x => x) - word2.Sum(x => x);
            return res;
        }
        static int Count(string word1,  string word2) 
        { 
            int count = 0; 
            //for hakerrank task we should return -1 if it's not possible to 
            //prevent one word to enother 
            if (word1.Length != word2.Length) return -1;
            
            
            int []char_count = new int[26]; 
  
            for (int i = 0; i < word1.Length; i++)  
                char_count[word1[i] - 'a']++;  
  
            for (int i = 0; i < word2.Length; i++)  
                if (char_count[word2[i] - 'a']-- <= 0) 
                    count++; 
          
            
            return count; 
        } 
        public static List<int> getMinimumDifference(List<string> a, List<string> b)
        {
            for(int i=0; i< a.Count; i++)
            {
                //Check(a[i].ToCharArray(), b[i].ToCharArray());
                Count(a[i], b[i]);
            }
            return new List<int>();
        }
        /*public static void Main(string[] args)
        {
            List<string> a = new List<string>(){"dfd","a"};
            List<string> b = new List<string>(){"fd","bb"};

            getMinimumDifference(a, b);
            Console.ReadLine();
        }*/
    }
}
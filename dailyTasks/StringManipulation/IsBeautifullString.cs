using System;
using System.Text;

namespace dailyTasks.StringManipulation
{
    /// <summary>
    /// string abbbccdddaa => 1a3b2c3d2a
    /// </summary>
    public class BeautifullString
    {
        public string IsBeautifull(string inputString)
        {
            if(string.IsNullOrEmpty(inputString)) return string.Empty;

            var res = new StringBuilder();
            int c = 1;
            
            for (int i = 1; i < inputString.Length; i++)
            {
                if (inputString[i] == inputString[i-1])
                    c++;
                
                else
                {
                    res.Append(c).Append(inputString[i-1]);
                    c = 1;
                }
            }

            res.Append(c).Append(inputString[^1]);

            return res.ToString();
        }
    }

    public static class Solution
    {
        public static void Main(string[] args)
        {
            var inputString = "abbbccdddaa";
            var beautify = new BeautifullString().IsBeautifull(inputString);
            
            Console.WriteLine(beautify);
            
        }
    }
}
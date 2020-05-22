using System.Linq;

namespace dailyTasks.Arrays
{
    public class Pangrams
    {
        /*
  static void Main(string[] args)
  {
      
      string value = @System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
      // If necessary, create it.
      if (value == null)
      {
          Environment.SetEnvironmentVariable("OUTPUT_PATH", "Value1");
      }

      TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
      

      string s = "We promptly judged antique ivory buckles for the prize";//Console.ReadLine();

      string result = pangrams(s);
      

      textWriter.WriteLine(result);

      textWriter.Flush();
      textWriter.Close();
  }
  */

        private const string alphabet = "abcdefghigklmnopqrstuvwxyz";
        private static string pangrams(string s)
        {
            var res = s.Trim().ToLower().ToCharArray().Distinct();
            //char 32'' is wroted inside of array of chars what is confusing..
            if(res.Count()-1 != alphabet.Length) return "not pangram";
            return "pangram";
        }
    }
}
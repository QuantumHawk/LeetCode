using System;
using System.Collections.Generic;
using System.Linq;

namespace dailyTasks
{
    public class Janea
    {
        //https://www.codeproject.com/Tips/869198/Balanced-Index-of-an-Array
        public static int balancedSum(List<int> arr)
        {
            int i = 0;
            int totalArraySum = 0;

            int leftsum = 0;

            for (i = 0; i < arr.Count(); i++)
                totalArraySum += arr[i];

            for (i = 0; i < arr.Count(); i++)
            {
                totalArraySum -= arr[i];

                if (i > 0  && leftsum == totalArraySum)
                    return i;

                if (i == arr.Count() - 1 )
                {
                    return -1;
                }

                leftsum += arr[i];
            }

            return -1;   
        }

        //-2063202565
        //316033704
        //-727379968
        //issue with Mono, so split looks like this
        public static long countMax(List<string> upRight)
        {
            var space = new char[0];
            long row = long.Parse(upRight[1].Split(space, StringSplitOptions.None)[0]);
            long col = long.Parse(upRight[1].Split(space, StringSplitOptions.None)[1]);

            for (int i=0; i<upRight.Count; i++)
            {
                var row1 = long.Parse(upRight[i].Split(space, StringSplitOptions.None)[0]);
                var col1 = long.Parse(upRight[i].Split(space, StringSplitOptions.None)[1]);
                
                if (row > row1) row = row1;
                if (col > col1) col = col1;
            }

            return (col * row);
        }
        public static void Main(string[] args)
        {
            //countMax
            var l = new List<string>(){"1 4", "2 3", "4 1"};
            var res = countMax(l);
            
            Console.WriteLine();

            /*balancedSum
             List<int> arr = new List<int>(){ 1,2,3,3 };

            var res = balancedSum(arr);

            Console.WriteLine(balancedSum(arr));*/
        }
        

    }
}

/*TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

int upRightCount = Convert.ToInt32(Console.ReadLine().Trim());

List<string> upRight = new List<string>();

for (int i = 0; i < upRightCount; i++)
{
    string upRightItem = Console.ReadLine();
    upRight.Add(upRightItem);
}

long result = Result.countMax(upRight);

textWriter.WriteLine(result);

textWriter.Flush();
textWriter.Close();*/
/*TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

int upRightCount = Convert.ToInt32(Console.ReadLine().Trim());

List<string> upRight = new List<string>();

for (int i = 0; i < upRightCount; i++)
{
    string upRightItem = Console.ReadLine();
    upRight.Add(upRightItem);
}

long result = Result.countMax(upRight);

textWriter.WriteLine(result);

textWriter.Flush();
textWriter.Close();*/
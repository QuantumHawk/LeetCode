using System.Collections.Generic;

namespace dailyTasks.Arrays
{
    /**
 * Created by Sergii on 25.07.2016.
 * 118. Pascal's Triangle
 * https://leetcode.com/problems/pascals-triangle/
 *
 * Given numRows, generate the first numRows of Pascal's triangle.
 * For example, given numRows = 5, Return:
 * [
 [1],
 [1,1],
 [1,2,1],
 [1,3,3,1],
 [1,4,6,4,1]
 ]
 https://en.wikipedia.org/wiki/Pascal's_triangle
 https://discuss.leetcode.com/topic/5128/solution-in-java
 https://discuss.leetcode.com/topic/6805/my-concise-solution-in-java
 */
    public class PascalTriangle
    {
            public List<List<int>> generate(int numRows)
    {
        var allrows = new List<List<int>>();
        var row = new List<int>();
        for(int i=0;i<numRows;i++)
        {
            row.Add(0);
            row.Add(1);
            for(int j=1;j<row.Count-1;j++)
                row[j]= row[j]+row[j+1];
            allrows.Add(new List<int>(row));
        }
        return allrows;

    }
    }
}


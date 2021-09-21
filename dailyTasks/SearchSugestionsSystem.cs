// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Linq;
//
// namespace dailyTasks
// {
//     public class SearchSugestionsSystem
//     {
//
//         /*
//          * Complete the 'searchSuggestions' function below.
//          *
//          * The function is expected to return a 2D_STRING_ARRAY.
//          * The function accepts following parameters:
//          *  1. STRING_ARRAY repository
//          *  2. STRING customerQuery
//          */
//
//         public static List<List<string>> searchSuggestions(List<string> repository, string customerQuery)
//         {
//             repository.Sort();
//         
//             var result = new List<List<string>>();
//         
//             for(int i =0; i < customerQuery.Length; i++)
//             {
//             
//                 filter(repository, i, customerQuery[i]);
//             
//                 var top = new List<string>();
//                 for(int j=0; j<3 && j< repository.Count; j++)
//                 {
//                     top.Add(repository[j]);
//                 }
//             
//                 if(i ==0) continue;
//             
//                 result.Add(top);            
//             }  
//         
//             return result;
//         }
//     
//         public static void filter(List<string> prod, int num, char c)
//         {
//             for(int i = prod.Count-1; i>=0; i--)
//             {
//                 if(prod[i].Length < (num+1) || prod[i][num] != c)
//                 {
//                     prod.RemoveAt(i);
//                 }
//             }
//         }
//         
//         public List<List<string>> suggestedProd(List<string> repository,  string customerQuery) 
//         {
//             var result = new List<List<string>>();
//             int l=0, r=repository.Count -1;
//                 
//             repository.Sort();
//             var q = customerQuery.ToLower();
//         
//             for(int i=0; i< customerQuery.Length; i++)
//             {
//                 var res = new List<string>();
//                 var c = customerQuery[i];
//             
//                 while(l <= r && (repository[l].Length == i || repository[l][i]<c)) l++;
//                 while(l <= r && (repository[r].Length ==i || repository[r][i]>c)) r--;
//             
//                 for(int j =0; j<3 && l+j <= r; j++)
//                     res.Add(repository[l+j]);
//             
//                 result.Add(res);
//             }
//         
//             return result;
//         }
//         
//     }
//
//
//
//     class Solution
//         {
//             public static void Main(string[] args)
//             {
//                 TextWriter textWriter =
//                     new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
//
//                 int repositoryCount = Convert.ToInt32(Console.ReadLine().Trim());
//
//                 List<string> repository = new List<string>();
//
//                 for (int i = 0; i < repositoryCount; i++)
//                 {
//                     string repositoryItem = Console.ReadLine();
//                     repository.Add(repositoryItem);
//                 }
//
//                 string customerQuery = Console.ReadLine();
//
//                 List<List<string>> result = SearchSugestionsSystem.searchSuggestions(repository, customerQuery);
//
//                 textWriter.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));
//
//                 textWriter.Flush();
//                 textWriter.Close();
//             }
//
//         }
//     }
// }
//
//
// using System.CodeDom.Compiler;
// using System.Collections.Generic;
// using System.Collections;
// using System.ComponentModel;
// using System.Diagnostics.CodeAnalysis;
// using System.Globalization;
// using System.IO;
// using System.Linq;
// using System.Reflection;
// using System.Runtime.Serialization;
// using System.Text.RegularExpressions;
// using System.Text;
// using System;
//
//
//
// class Result
// {
//
//     /*
//      * Complete the 'searchSuggestions' function below.
//      *
//      * The function is expected to return a 2D_STRING_ARRAY.
//      * The function accepts following parameters:
//      *  1. STRING_ARRAY repository
//      *  2. STRING customerQuery
//      */
//
//     public static List<List<string>> searchSuggestions(List<string> repository, string customerQuery)
//     {
//         repository.Sort();
//         
//         var result = new List<List<string>>();
//         var q = customerQuery.ToLower();
//         
//         for(int i =0; i < q.Length; i++)
//         {
//             
//             filter(repository, i, q[i]);
//             
//             var top = new List<string>();
//             for(int j=0; j<3 && j< repository.Count; j++)
//             {
//                 top.Add(repository[j].ToLower());
//             }
//             
//             if(i ==0) continue;
//             
//             result.Add(top);            
//         }  
//         
//         return result;
//     }
//     
//     public static void filter(List<string> prod, int num, char c)
//     {
//         for(int i = prod.Count-1; i>=0; i--)
//         {
//             var word = prod[i].ToLower();
//             if(word.Length < (num+1) || word[num] != c)
//             {
//                 prod.RemoveAt(i);
//             }
//         }
//     }
//
// }
//
// class Solution
// {
//     public static void Main(string[] args)
//     {
//         TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
//
//         int repositoryCount = Convert.ToInt32(Console.ReadLine().Trim());
//
//         List<string> repository = new List<string>();
//
//         for (int i = 0; i < repositoryCount; i++)
//         {
//             string repositoryItem = Console.ReadLine();
//             repository.Add(repositoryItem);
//         }
//
//         string customerQuery = Console.ReadLine();
//
//         List<List<string>> result = Result.searchSuggestions(repository, customerQuery);
//
//         textWriter.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));
//
//         textWriter.Flush();
//         textWriter.Close();
//     }
// }

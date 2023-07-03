
using System;

namespace LongestSubsequence
{
    internal class Program
    {
        public static string FindShortestString (string[] inputStrArr) {
            var shortestStr = inputStrArr[0]; 
            foreach (var item in inputStrArr)
                if (shortestStr.Length > item.Length) shortestStr = item;
            return shortestStr;
        }
        public static (string subString, bool isSubstring) IsOneSubstring(string shortestStr, int i, int j, string[] inputStrArr) {
            var subString = shortestStr.Substring(i,j-i);
                    var isSubstring = true;
                    foreach (var item in inputStrArr) 
                    {
                        if (!(item.Contains(subString))) {
                            isSubstring = false;
                            break;
                            }
                    }
            return (subString, isSubstring);
        }
        public static string LongestSubsequence (string[] inputStrArr) {
            var shortestStr = FindShortestString(inputStrArr);
            var result = "";
            for (var i = 0; i<shortestStr.Length - 1; i++) {
                for (var j = i + 1; j<shortestStr.Length; j++) {
                    var (subString, isSubstring) = IsOneSubstring(shortestStr, i, j, inputStrArr);
                    if (isSubstring & result.Length < subString.Length) result = subString;
                }
            }
            return result;
            
        }
        static void Main(string[] args)
        {

            Console.WriteLine(
                LongestSubsequence(new string[3] {
                    "epidemiologist", 
                    "refrigeration", 
                    "supercalifragilisticexpialodocious"}));
        }
    }
}
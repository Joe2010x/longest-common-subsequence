
using System;
using System.Linq;
using System.Collections.Generic;

namespace LongestSubsequence
{
    internal class Program
    {
        public static string LongestSubsequence (string[] inputStrArr) {
            var result = "";
            var firstStr = inputStrArr[0];
            var restStrArr = inputStrArr.Skip(1).ToArray();
            foreach (var charX in firstStr)
            {
                var allContainCharX = true;
                for (var i = 0; i<restStrArr.Length; i++) {
                    if (!restStrArr[i].Contains(charX)) {
                        allContainCharX = false;
                        break;
                    } 
                }
                if (allContainCharX) {
                    for (var i= 0; i<restStrArr.Length; i++) {
                        restStrArr[i] = restStrArr[i].Substring(restStrArr[i].IndexOf(charX)+1);
                    }
                    result += charX;
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
                    "supercalifragilisticexpialodocious"
                    }));
        }
    }
}